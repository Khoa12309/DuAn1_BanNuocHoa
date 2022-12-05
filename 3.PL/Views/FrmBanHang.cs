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
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace _3.PL.Views
{
    public partial class FrmBanHang : Form
    {
        FilterInfoCollection asd;
        VideoCaptureDevice vn;
        private IGioHangChiTietSer _Iserghct;
        private ISanPhamSer _Isersp;
        private List<GioHangChiTietView> _lstghct;
        
        public FrmBanHang()
        {
            InitializeComponent();
            _Iserghct=new GioHangChiTietSer();
            _Isersp=new SanPhamSer();
            _lstghct=new List<GioHangChiTietView>();
            loadcam();
            // loadcmb();
            loadfrmgh();
            loadfrmsp();

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
                dgrid_sp.Rows.Add(stt++, x.ID, x.MaSp, x.TenSp, x.MuiHuong, x.DungTich, x.Solong,x.tenloai, x.tenhang,x.GiaBan);
            }
        }

        private void loadfrmgh()
        {
            dgrid_hd.ColumnCount = 6;
            var stt = 1;
            dgrid_hd.Columns[0].Name = "Stt";
            dgrid_hd.Columns[1].Name = "Mã";
            dgrid_hd.Columns[2].Name = "Tên";
            dgrid_hd.Columns[3].Name = "Số Lượng";
            dgrid_hd.Columns[4].Name = "Số Lượng";
            dgrid_hd.Columns[5].Name = "Thành Tiền";

            dgrid_hd.Rows.Clear();
            foreach (var x in _lstghct)
            {
                var gh = _Isersp.SpGetAll().FirstOrDefault(c => c.ID == x.IdSP);
                dgrid_hd.Rows.Add(stt++,gh.MaSp,gh.TenSp,x.SoLuong,gh.GiaBan,x.SoLuong*gh.GiaBan);

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
            asd = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in asd)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
            vn = new VideoCaptureDevice(asd[comboBox1.SelectedIndex].MonikerString);
            vn.NewFrame += Vn_NewFrame;
            vn.Start();
           
        }

        private void Vn_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private static byte[] ToByteArray(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
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
    }
}
