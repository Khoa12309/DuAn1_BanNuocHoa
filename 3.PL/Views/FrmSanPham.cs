using _1.DAL.IRepositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using QRCoder;
using System.Runtime.Serialization.Formatters.Binary;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private ISanPhamSer _Iser;

        private ILoaiSer _LoaiSer;
        private IHangSer _HangSer;
        private Guid _id;
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string ma;
        string taikh;
        string chuoiten = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";

        public FrmSanPham()
        {
            InitializeComponent();

            _HangSer = new HangSpSer();
            _Iser = new SanPhamSer();
            _LoaiSer = new LoaiSpSer();
            loadcmb();
            loadfrm();
        }

        private void loadfrm()
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
            dgrid_sp.Columns[7].Name = "Trạng Thái";
            dgrid_sp.Columns[8].Name = "Loại";
            dgrid_sp.Columns[9].Name = "Hãng";
            dgrid_sp.Columns[10].Name = "Giá Nhập";
            dgrid_sp.Columns[11].Name = "Giá Bán";
           

            dgrid_sp.Rows.Clear();
            this.dgrid_sp.Columns["ID"].Visible = false;
            foreach (var x in _Iser.SpGetAll())
            {
                dgrid_sp.Rows.Add(stt++, x.ID, x.MaSp, x.TenSp, x.MuiHuong, x.DungTich, x.Solong, x.TrangThai, x.TenLoai, x.TenHang, x.GiaNhap, x.GiaBan);
            }


        }

        private void loadcmb()
        {
            foreach (var x in _HangSer.HspGetAll())
            {
                cmb_Hang.Items.Add(x.TenHang);
            }
<<<<<<< HEAD
            //cmb_Hang.SelectedIndex = 0;
=======
       //     cmb_Hang.SelectedIndex = 0;
>>>>>>> origin/Dungndph20833
            foreach (var x in _LoaiSer.LspGetAll())
            {
                cmb_loai.Items.Add(x.TenloaiSp);
            }
           // cmb_loai.SelectedIndex = 0;

        }
        private Image img(byte[] bt)
        {
         
            MemoryStream ms = new MemoryStream(bt);
            var a = Image.FromStream(ms);
            return a;
        }
        private byte[] epbyte(PictureBox pc)
        {
            MemoryStream ms = new MemoryStream();
            pcb_anh.Image.Save(ms, pcb_anh.Image.RawFormat);
            return ms.ToArray();
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn Hình Ảnh";
            opf.Filter = "Image Files (*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pcb_anh.ImageLocation = opf.FileName;
            }
        }
        private SanPhamView getfrm()
        {
            return new SanPhamView()
            {
                DungTich = txt_dt.Text,
                GiaBan = float.Parse(txt_gb.Text),
                GiaNhap = float.Parse(txt_gn.Text),
                HinhAnh = epbyte(pcb_anh),
                MaSp = txt_masp.Text,
                MuiHuong = txt_muisp.Text,
                Solong = int.Parse(txt_sl.Text),
                TenSp = txt_tensp.Text,
                IDHang = _HangSer.HspGetAll()[cmb_Hang.SelectedIndex].ID,
                IDLSp = _LoaiSer.LspGetAll()[cmb_loai.SelectedIndex].Id,
                TrangThai = rbtn_ch.Checked == true ? 1 : 0,
                ID = _id
            };
        }
       

        private void dgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = e.RowIndex;
                if (row == _Iser.SpGetAll().Count) return;
                _id = Guid.Parse(dgrid_sp.Rows[row].Cells[1].Value.ToString());
                var dt = _Iser.SpGetAll().FirstOrDefault(c => c.ID == _id);
                pcb_anh.Image = img(dt.HinhAnh);
                txt_dt.Text = dt.DungTich;
                txt_gb.Text = dt.GiaBan.ToString();
                txt_gn.Text = dt.GiaNhap.ToString();
                txt_masp.Text = dt.MaSp;
                txt_muisp.Text = dt.MuiHuong.ToString();
                txt_sl.Text = dt.Solong.ToString();
                txt_tensp.Text = dt.TenSp;
                var loai = _LoaiSer.LspGetAll().FirstOrDefault(c => c.Id == dt.IDLSp);
                var hang = _HangSer.HspGetAll().FirstOrDefault(c => c.ID == dt.IDHang);

                cmb_Hang.SelectedIndex = cmb_Hang.FindStringExact(hang.TenHang);
                cmb_loai.SelectedIndex = cmb_loai.FindStringExact(loai.TenloaiSp);
                rbtn_ch.Checked = dt.TrangThai == 1 ? true : false;
                rrbtn_hh.Checked = dt.TrangThai == 0 ? true : false;
                ma = dt.MaSp;
                var idsp = _id.ToString();
                if (idsp == null)
                {
                    MessageBox.Show("Hãy Chọn sp");
                }
                else
                {
                    pb.Image = (qr(idsp));                    
                }
            }
            catch (Exception cv)
            {
               MessageBox.Show("Lỗi :" +cv.Message);
            }            
        }
        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        private bool kiemtraten(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoisdt)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        public bool checkma(string ma2)
        {
            if (ma2 == ma) { return true; }
            else if (checktrung(ma2) == true) { return false; }
            else { return true; }
            return true;

        }
        public bool checktrung(string masp)
        {
            var r = _Iser.SpGetAll().Any(c => c.MaSp == masp);
            if (r == true) { return true; }
            return false;
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                if (txt_masp.Text.Trim() == "" || kiemtrakitu(txt_masp.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã sản phẩm hoặc mã sản phẩm có có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(txt_masp.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã sản phẩm");
                    return;
                }
                else if (txt_tensp.Text.Trim() == "" || kiemtrakitu(txt_tensp.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên sản phẩm hoặc tên sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (txt_muisp.Text.Trim() == "" || kiemtrakitu(txt_muisp.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống mùi sản phẩm hoặc có kí tự đặc biệt");
                    return;
                }
                else if (txt_dt.Text.Trim() == "" || kiemtraten(txt_dt.Text.Trim()) == false)
                {
                    MessageBox.Show("dung tích trống hoặc sai định dạng");
                    return;
                }
                else if (pcb_anh.Image == null)
                {

                    MessageBox.Show("Chọn ảnh cho sản phẩm");
                    return;

                }
                else if (txt_sl.Text.Trim() == "" || kiemtraten(txt_sl.Text.Trim()) == false) 
                {
                    MessageBox.Show("Bạn đang để trống số lượng bán hoặc số lượng sai định dạng");
                    return;
                }
                else if (txt_gb.Text.Trim() == "" || kiemtraten(txt_gb.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá bán hoặc giá bán sai định dạng");
                    return;
                }
                else if (txt_gn.Text.Trim() == "" || kiemtraten(txt_gn.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá nhập hoặc giá nhập sai định dạng");
                    return;
                }
                else if (Convert.ToDecimal(txt_gb.Text) - Convert.ToDecimal(txt_gn.Text) <= 0)
                {
                    MessageBox.Show("Giá chưa hợp lí");
                    return;
                }
                else
                {
                    _id = Guid.NewGuid();
                    MessageBox.Show(_Iser.Add(getfrm()));
                    txt_dt.Clear();
                    txt_gb.Clear();
                    loadfrm();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                if (txt_masp.Text.Trim() == "" || kiemtrakitu(txt_masp.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã sản phẩm hoặc mã sản phẩm có có kí tự đặc biệt");
                    return;
                }
                else if (checkma(txt_masp.Text.Trim()) == false)
                {
                    MessageBox.Show("Trùng mã sản phẩm");
                    return;
                }
                else if (txt_tensp.Text.Trim() == "" || kiemtrakitu(txt_tensp.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên sản phẩm hoặc tên sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (txt_muisp.Text.Trim() == "" || kiemtrakitu(txt_muisp.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống mùi sản phẩm hoặc có kí tự đặc biệt");
                    return;
                }
                else if (txt_dt.Text.Trim() == "" || kiemtraten(txt_dt.Text.Trim()) == false)
                {
                    MessageBox.Show("dung tích trống hoặc sai định dạng");
                    return;
                }
                else if (pcb_anh.Image == null)
                {

                    MessageBox.Show("Chọn ảnh cho sản phẩm");
                    return;

                }
                else if (txt_sl.Text.Trim() == "" || kiemtraten(txt_sl.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống số lượng bán hoặc số lượng sai định dạng");
                    return;
                }
                else if (txt_gb.Text.Trim() == "" || kiemtraten(txt_gb.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá bán hoặc giá bán sai định dạng");
                    return;
                }
                else if (txt_gn.Text.Trim() == "" || kiemtraten(txt_gn.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá nhập hoặc giá nhập sai định dạng");
                    return;
                }
                else if (Convert.ToDecimal(txt_gb.Text) - Convert.ToDecimal(txt_gn.Text) <= 0)
                {
                    MessageBox.Show("Giá chưa hợp lí");
                    return;
                }
                else
                {
                    MessageBox.Show(_Iser.Update(getfrm()));
                    loadfrm();
                }

            }
            else
            {
                return;

            }
        

        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_Iser.Delete(getfrm()));
                loadfrm();
            }
            else { return; }
        }
       
        private Image qr(string spv)
        {

            QRCodeGenerator qRCode = new QRCodeGenerator();            
            var b = qRCode.CreateQrCode((spv), QRCodeGenerator.ECCLevel.Q);
            var a = new QRCode(b);
            return a.GetGraphic(50);
        }
        private void btn_taoqr_Click(object sender, EventArgs e)
        {

            var idsp = _id.ToString();
            if (idsp == null)
            {
                MessageBox.Show("Hãy Chọn sp");
            }
            else
            {
                pb.Image = (qr(idsp));
                
            }
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var stt = 1;
            dgrid_sp.ColumnCount = 12;
            dgrid_sp.Columns[0].Name = "Stt";
            dgrid_sp.Columns[1].Name = "ID";
            dgrid_sp.Columns[2].Name = "Mã SP";
            dgrid_sp.Columns[3].Name = "Tên SP";
            dgrid_sp.Columns[4].Name = "Mùi Hương";
            dgrid_sp.Columns[5].Name = "Dung Tích";
            dgrid_sp.Columns[6].Name = "Số Lượng";
            dgrid_sp.Columns[7].Name = "Trạng Thái";
            dgrid_sp.Columns[8].Name = "Loại";
            dgrid_sp.Columns[9].Name = "Hãng";
            dgrid_sp.Columns[10].Name = "Giá Nhập";
            dgrid_sp.Columns[11].Name = "Giá Bán";
            //dgrid_sp.Columns[12].Name = "Hình Ảnh";

            dgrid_sp.Rows.Clear();
            this.dgrid_sp.Columns["ID"].Visible = false;
            foreach (var x in _Iser.SpGetAll().Where(c=>c.MaSp==txt_tk.Text||c.TenSp==txt_tk.Text))
            {
                dgrid_sp.Rows.Add(stt++, x.ID, x.MaSp, x.TenSp, x.MuiHuong, x.DungTich, x.Solong, x.TrangThai, x.Tenloai, x.Tenhang, x.GiaNhap, x.GiaBan);
            }
=======
>>>>>>> TheAnh

        }

        //private Object ByteArrayToObject(byte[] arrBytes)
        //{
        //    MemoryStream memStream = new MemoryStream();
        //    BinaryFormatter binForm = new BinaryFormatter();
        //    memStream.Write(arrBytes, 0, arrBytes.Length);
        //    memStream.Seek(0, SeekOrigin.Begin);
        //    Object obj = (Object)binForm.Deserialize(memStream);
        //    return obj;
        //}
    }
}
