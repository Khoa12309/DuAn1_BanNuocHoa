using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace _3.PL.Views
{
    public partial class FrmBanHang : Form
    {
        FilterInfoCollection tcam;
        VideoCaptureDevice cam;
        private IGioHangChiTietSer _Iserghct;
        private ISanPhamSer _Isersp;
        private List<GioHangChiTietView> _lstghct;
        private IHoaDonSer _ihdser;
        private IHoaDonChiTietSer _ihdctser;
        private IKhachHangSer _ikhser;
        private INhanVienSer _invser;
        private IKhuyenMaiSer _Ikmser;
        Guid _id ;
        float tt = 0;
        public FrmBanHang()
        {
            InitializeComponent();
            _Iserghct=new GioHangChiTietSer();
            _Isersp=new SanPhamSer();
            _lstghct=new List<GioHangChiTietView>();
            _ikhser = new KhachHangSer();
            _Ikmser= new KhuyenMaiSer();   
            _invser= new NhanVienSer();
            _ihdser=new HoaDonSer();
            _ihdctser = new HoaDonCtSer();
            loadcam();
            // loadcmb();
            loadfrmgh();
            loadfrmsp();
            loadhd();
            Loadcmb();

        }

        private void loadhd()
        {
            dgrid_hd.ColumnCount = 5;
            var stt = 1;
            dgrid_hd.Columns[0].Name = "Stt";
            dgrid_hd.Columns[1].Name = "Mã";
            dgrid_hd.Columns[2].Name = "Ngày";
            dgrid_hd.Columns[3].Name = "Trạng Thái";
            dgrid_hd.Columns[4].Name = "ID";
            this.dgrid_hd.Columns[4].Visible = false;

            dgrid_gh.Rows.Clear();
            foreach (var x in _ihdser.HdGetAll())
            {
                dgrid_hd.Rows.Add(stt++, x.MaHD, x.NgayMua, x.TrangThai == 0 ? "Chưa thanh toán":"Đã thanh toán",x.Id);
            }
        }

        private void Loadcmb()
        {
            foreach (var x in _ikhser.KhGetAll())
            {
                cmb_kh.Items.Add(x.TenKH);

            } 
            foreach (var x in _invser.NvGetAll())
            {
                cmb_nv.Items.Add(x.TenNV);

            } 
            foreach (var x in _Ikmser.KmGetAll())
            {
                cmb_km.Items.Add(x.MaKM);

            }
        }

        private void loadfrmsp()
        {
            var stt = 1;
            dgrid_sp.ColumnCount = 12;
            dgrid_sp.Columns[0].Name = "Stt";
            dgrid_sp.Columns[1].Name = "ID";
            dgrid_sp.Columns[2].Name = "Mã SP";
            dgrid_sp.Columns[3].Name = "Tên SP";
            dgrid_sp.Columns[4].Name = "Mùi Hương";
            dgrid_sp.Columns[5].Name = "Dung Tích";
            dgrid_sp.Columns[6].Name = "Số Lượng";           
            dgrid_sp.Columns[7].Name = "Loại";
            dgrid_sp.Columns[8].Name = "Hãng";          
            dgrid_sp.Columns[9].Name = "Giá Bán";
            //dgrid_sp.Columns[12].Name = "Hình Ảnh";

            dgrid_sp.Rows.Clear();
            this.dgrid_sp.Columns["ID"].Visible = false;
            foreach (var x in _Isersp.SpGetAll())
            {
                dgrid_sp.Rows.Add(stt++, x.ID, x.MaSp, x.TenSp, x.MuiHuong, x.DungTich, x.Solong,x.Tenloai, x.Tenhang,x.GiaBan);
            }
        }

        private void loadfrmgh()
        {
            dgrid_gh.ColumnCount = 6;
            var stt = 1;
            dgrid_gh.Columns[0].Name = "Stt";
            dgrid_gh.Columns[1].Name = "Mã";
            dgrid_gh.Columns[2].Name = "Tên";
            dgrid_gh.Columns[3].Name = "Số Lượng";
            dgrid_gh.Columns[4].Name = "Giá";
            dgrid_gh.Columns[5].Name = "Thành Tiền";

            dgrid_gh.Rows.Clear();
            foreach (var x in _lstghct)
            {
                var gh = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == x.IdSP);
                dgrid_gh.Rows.Add(stt++,gh.MaSp,gh.TenSp,x.SoLuong,gh.GiaBan,x.SoLuong*gh.GiaBan);

            }
        }
        private void addGH(Guid id)
        {
            var sp = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == id);
            var dt = _lstghct.FirstOrDefault(c=>c.IdSP==id);
            if (dt==null)
            {

                GioHangChiTietView ghct = new GioHangChiTietView()
                {
                    DonGia = sp.GiaBan,
                     SoLuong=1,
                      IdGH=Guid.NewGuid(),
                       IdSP=id
                    
                };
                _lstghct.Add(ghct);
            }
            else
            {
                dt.SoLuong++;
            }
            loadfrmgh();
        }

        private void loadcmb()
        {
            throw new NotImplementedException();
        }

       

        private void loadcam()
        {
            tcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in tcam)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
            cam = new VideoCaptureDevice(tcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Vn_NewFrame;
            cam.Start();
           
        }

        private void Vn_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);

              
                if (result != null)
                {
                    //  button2.Text = result.ToString();
                    var idg = Guid.Parse(result.ToString());
                    addGH(idg);                  
                }
            }
            else MessageBox.Show("null");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimerBH.Start();
        }
        private Image img(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(bt);
            var a = Image.FromStream(ms);
            return a;
        }
        private void dgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var id = Guid.Parse(dgrid_sp.Rows[row].Cells[1].Value.ToString());
            var z = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == id);
            addGH((Guid)z.ID);
            pb_anh.Image = img(z.HinhAnh);
        }

        private void dgrid_hd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                var row= e.RowIndex;
                _id = Guid.Parse(dgrid_hd.Rows[row].Cells[4].Value.ToString());
                var dt = _ihdser.HdGetAll().FirstOrDefault(c => c.Id == _id);
                var kh = _ikhser.KhGetAll().FirstOrDefault(c => c.Id == dt.IdKH);
                var nv = _invser.NvGetAll().FirstOrDefault(c => c.Id == dt.IdNV);
                txt_mhd1.Text = dt.MaHD;
                dtp_ntt.Text= dt.NgayMua.ToString();
                txt_tk.Text = kh.TenKH;
                txt_tnv.Text = nv.TenNV;
                txt_tt.Text = dt.TongTien.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex);
            }
        }

       

        private void txt_mhd_TextChanged(object sender, EventArgs e)
        {
            txt_tth.Text = _id.ToString();

        }
        private float tinhtien(int gkm)
        {
            foreach (var x in _lstghct)
            {
                tt += x.SoLuong * x.DonGia;
            }
            if (gkm!=0)
            {
                return tt-=tt*(gkm/100);
            }
            return tt;
        }
    private void btn_thd_Click(object sender, EventArgs e)
        {
            
            
            HoaDonView hd = new HoaDonView()
            {
                Id = Guid.NewGuid(),
                IdKH = _ikhser.KhGetAll()[cmb_kh.SelectedIndex].Id,
                IdNV = _invser.NvGetAll()[cmb_nv.SelectedIndex].Id,
                MaHD = txt_mhd.Text,
                NgayMua = dtp_nm.Value,
                TrangThai = 0,
                TongTien = tt,
                IdKM = Guid.Parse("02e3a23d-24f3-4c25-8819-6f98918b058c"),

            };
            _ihdser.Add(hd);          
            foreach (var x in _lstghct)
            {
                var hdct = new HoaDonChiTietView()               
                {
                     DonGia=x.DonGia,
                      SoLuong=x.SoLuong,
                       IdSP=x.IdSP,
                       IdHD =hd.Id,                  
                };
                _ihdctser.Add(hdct);
                var sp = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == x.IdSP);
                sp.Solong -= x.SoLuong;
               _Isersp.Update(sp);
            }
            MessageBox.Show("Tao hoa don thanh cong");
            _lstghct.Clear();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            var kh = _ikhser.KhGetAll().FirstOrDefault(c => c.TenKH == txt_tk.Text);
            var nv = _invser.NvGetAll().FirstOrDefault(c => c.TenNV == txt_tnv.Text);
            HoaDonView hd = new HoaDonView()
            {
                Id =_id,
                IdKH = kh.Id,
                IdNV = nv.Id,
                MaHD = txt_mhd1.Text,
                NgayMua = dtp_ntt.Value,
                TrangThai = 1,
                TongTien = tinhtien((int)_Ikmser.KmGetAll()[cmb_km.SelectedIndex].GiaTriKM),
                IdKM = _Ikmser.KmGetAll()[cmb_km.SelectedIndex].Id,
            };
            _ihdser.Update(hd);
            

            SaveFileDialog of = new SaveFileDialog()
            {
                Filter = "PDF flie|*.pdf", ValidateNames = true,


            };
            if (of.ShowDialog()==DialogResult.OK)
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A7.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(of.FileName, FileMode.Create));
                doc.Open();
                //doc.Add();
            }

            
        }
        private void ihd()
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
    }
}
