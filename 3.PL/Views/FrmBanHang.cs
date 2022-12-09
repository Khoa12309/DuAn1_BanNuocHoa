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
using Point = System.Drawing.Point;

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
        float tt ;
        bool check = false;
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

            dgrid_hd.Rows.Clear();
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
            cmb_km.SelectedIndex = 0;   
            cmb_kh.SelectedIndex = 0;
            cmb_nv.SelectedIndex = 0;
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
            timer1.Start();
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
                var km = _Ikmser.KmGetAll().FirstOrDefault(c => c.Id == dt.IdKM);
                txt_mhd1.Text = dt.MaHD;
                dtp_ntt.Text= dt.NgayMua.ToString();
                txt_tk.Text = kh.TenKH;
                txt_tnv.Text = nv.TenNV;
                txt_tt.Text = dt.TongTien.ToString();
                txt_km.Text = (dt.TongTien * km.GiaTriKM / 100).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
            }
        }
        private void txt_mhd_TextChanged(object sender, EventArgs e)
        {
         

        }
       
        private HoaDonView hdw()
        {
           float tt = 0;
            foreach (var x in _lstghct)
            {
                tt += x.SoLuong * x.DonGia;
            }

            return new HoaDonView()
            {
                 Id=_id,
                IdKH = _ikhser.KhGetAll()[cmb_kh.SelectedIndex].Id,
                IdNV = _invser.NvGetAll()[cmb_nv.SelectedIndex].Id,
                MaHD = txt_mhd.Text,
                NgayMua = dtp_nm.Value,
                TrangThai = 0,
                TongTien = tt,
                IdKM = _Ikmser.KmGetAll()[cmb_km.SelectedIndex].Id
            };
        }
    private void btn_thd_Click(object sender, EventArgs e)
        {           
           _id=Guid.NewGuid();
            _ihdser.Add(hdw());          
            foreach (var x in _lstghct)
            {
                var hdct = new HoaDonChiTietView()               
                {
                     DonGia=x.DonGia,
                      SoLuong=x.SoLuong,
                       IdSP=x.IdSP,
                       IdHD =hdw().Id,                  
                };
                _ihdctser.Add(hdct);
                var sp = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == x.IdSP);
                sp.Solong -= x.SoLuong;
               _Isersp.Update(sp);
            }
            MessageBox.Show("Tao hoa don thanh cong");
            _lstghct.Clear();
            loadfrmgh();
            loadhd();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = _ihdser.HdGetAll().FirstOrDefault(c => c.Id == _id);
                if (temp.TrangThai == 0)
                {
                    var temp1 = _Ikmser.KmGetAll().FirstOrDefault(c => c.Id == temp.IdKM);
                    temp.TrangThai = 1;
                    temp.TongTien = temp.TongTien - temp.TongTien * (int)temp1.GiaTriKM / 100;
                    check = true;
                   _ihdser.Update(temp);
                    loadhd();
                    DialogResult dialogResult = MessageBox.Show("Thanh toán thành công,bạn có muốn in hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult==DialogResult.Yes)
                    {
                        ihd();
                    }
                }
                else MessageBox.Show("Hóa đơn đã được thanh toán");
               
            }
            catch (Exception a)
            {

                MessageBox.Show("Lỗi : " + a);
            }
        }
        private void ihd()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();

        }

        private void pdhd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hd = _ihdser.HdGetAll().FirstOrDefault(c=>c.Id==_id);
            var kh = _ikhser.KhGetAll().FirstOrDefault(c => c.Id == hd.IdKH);
            var km = _Ikmser.KmGetAll().FirstOrDefault(c => c.Id == hd.IdKM);
            var nv = _invser.NvGetAll().FirstOrDefault(c => c.Id == hd.IdNV);

            //lấy chiều rộng của giấy
            var w =pdhd.DefaultPageSettings.PaperSize.Width;
            //
            e.Graphics.DrawString("Của Hàng Nước Hoa",new System.Drawing.Font("Times New Roman",15,FontStyle.Bold),Brushes.Black,new System.Drawing.Point(100,20));

            e.Graphics.DrawString(String.Format("Mã Hóa Đơn : {0}",hd.MaHD),new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w/2+200, 20));
            e.Graphics.DrawString(String.Format(" {0}",DateTime.Now.ToString()),new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w/2+200, 45));

            //
            Pen pn= new Pen(Color.Black,1);

            var y = 70;
            Point p1 = new Point(10,y);
            Point p2 = new Point(w-10,y);
            e.Graphics.DrawLine(pn,p1,p2);
            y+=10;
            e.Graphics.DrawString(String.Format("HÓA ĐƠN BÁN HÀNG"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2-100, y));
            y += 20;
            e.Graphics.DrawString(String.Format("Ngày Mua : {0}", hd.NgayMua), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
            e.Graphics.DrawString(String.Format("Tên Khách Hàng : {0}",kh.TenKH ), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
            e.Graphics.DrawString(String.Format("STD : {0}",kh.STD ), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y+30));
            y += 70;
            e.Graphics.DrawString(String.Format("STT"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y)); 
            e.Graphics.DrawString(String.Format("Tên Sản Phẩm"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
            e.Graphics.DrawString(String.Format("Số Lượng"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
            e.Graphics.DrawString(String.Format("Đơn Giá"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w/2+100, y));
            e.Graphics.DrawString(String.Format("Thành Tiền"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));

            /////
            ///
           

            int stt= 1;
            y += 20;
            
            foreach (var x in _ihdctser.HDCTGetAll().Where(c=>c.IdHD==_id) )
            {
                var thanhtien = x.SoLuong * x.DonGia;
                e.Graphics.DrawString(String.Format("{0}",stt++), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
                e.Graphics.DrawString(String.Format("{0}", x.tensp), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
                e.Graphics.DrawString(String.Format("{0}",x.SoLuong), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0}",x.DonGia), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
                e.Graphics.DrawString(String.Format("{0}",thanhtien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
                y += 20;
            }
            y += 20;
            e.Graphics.DrawLine(pn, p1, p2);
            y += 20;
            e.Graphics.DrawString(String.Format("Tổng Tiền : {0}",hd.TongTien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
        }
        private void btn_ihd_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                ihd();
                check = false;
            }
            else MessageBox.Show("Chọn hóa đơn để thanh toán trước khi in");
            
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            var kh = _ikhser.KhGetAll().FirstOrDefault(c => c.TenKH == txt_tk.Text);
            var nv = _invser.NvGetAll().FirstOrDefault(c => c.TenNV == txt_tnv.Text);
            var hd = _ihdser.HdGetAll().FirstOrDefault(c => c.Id == _id);
            HoaDonView hdw = new HoaDonView()
            {
                Id = _id,
                IdKH = kh.Id,
                IdNV = nv.Id,
                MaHD = hd.MaHD,
                NgayMua = hd.NgayMua,
                TrangThai = hd.TrangThai,
                TongTien = hd.TongTien,
                IdKM = hd.IdKM,
            };
            MessageBox.Show(_ihdser.Delete(hdw));
        }

        private void FrmBanHang_Leave(object sender, EventArgs e)
        {
            //if (cam.IsRunning && cam != null)
            //{
            //    timer1.Stop();
            //    cam.SignalToStop();
            //    cam.WaitForStop();
            //    cam = null;
            //}
        }

        private void txt_tkd_TextChanged(object sender, EventArgs e)
        {
            //tiền khách đưa ,tiền thừa  ,tt-=tt-km dg
            txt_tth.Text= (float.Parse(txt_tkd.Text)-float.Parse(txt_tt.Text)).ToString();
            //
        }

        private void txt_km_TextChanged(object sender, EventArgs e)
        {
            txt_tt.Text = (float.Parse(txt_tt.Text) - float.Parse(txt_km.Text)).ToString();
        }

        private void FrmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //timer1.Stop();
            //if (cam.IsRunning&& cam!=null)
            //{
            //    cam.Stop();
            //}
            
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam.IsRunning && cam != null)
            {
                //timer1.Stop();
                cam.SignalToStop();
                cam.WaitForStop();
                cam = null;
            }
        }
        private void FrmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (cam.IsRunning && cam != null)
            //{
            //    timer1.Stop();
            //    cam.Stop();               
            //}
        }
    }
}
