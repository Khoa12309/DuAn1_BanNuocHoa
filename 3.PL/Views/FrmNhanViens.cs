using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmTaiKhoan : Form
    {
        private IAccountSer _ItaiKhoanr;
        private AccountView _accountView;
        private INhanVienSer _InhanVienSer;
        private NhanVienView _NhanVienView;
        Guid _id;
        private List<string> GioiTinh = new List<string>() { "Nam", "Nữ" };
        private List<string> ChucVus = new List<string>() { "Quản lý","Nhân viên" };
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string ma;
        string taikh;
        string chuoiten = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        private AccountView acc;
        public FrmTaiKhoan()
        {
            InitializeComponent();
           
            _ItaiKhoanr = new AccountSer();
            _accountView = new AccountView();
            _InhanVienSer = new NhanVienSer();
            _NhanVienView = new NhanVienView();
             LoadData();
            loadcmb();
            rbtn_DangDiLam.Checked = true;
        }

        private void loadcmb()
        {
            foreach (var x in ChucVus)
            {
                cmb_ChucVu.Items.Add(x);
            }
            cmb_ChucVu.SelectedIndex = 0;
            foreach (var x in GioiTinh)
            {
                cmb_GioiTinh.Items.Add(x);
            }
            cmb_GioiTinh.SelectedIndex = 0;
        }

        public void LoadData()
        {
            int stt = 1;
            dgird_TaiKhoan.ColumnCount = 12;
            dgird_TaiKhoan.Columns[0].Name = "Stt";
            dgird_TaiKhoan.Columns[1].Name = "ID";
            dgird_TaiKhoan.Columns[1].Visible = false;
            dgird_TaiKhoan.Columns[2].Name = "Tên NV";
            dgird_TaiKhoan.Columns[3].Name = "Mã NV";
            dgird_TaiKhoan.Columns[4].Name = "Tên TK";
            dgird_TaiKhoan.Columns[5].Name = "Mật khẩu";
            dgird_TaiKhoan.Columns[6].Name = "Địa chỉ";
            dgird_TaiKhoan.Columns[7].Name = "Số DT";
            dgird_TaiKhoan.Columns[8].Name = "Trạng thái";
            dgird_TaiKhoan.Columns[9].Name = "Giới tính";
            dgird_TaiKhoan.Columns[10].Name = "Chức vụ";
            dgird_TaiKhoan.Columns[11].Name = "Email";
            dgird_TaiKhoan.Rows.Clear();
            foreach (var x in _InhanVienSer.NvGetAll())
            {
                dgird_TaiKhoan.Rows.Add(stt++, x.Id, x.TenNV, x.MaNV, x.tk,x.mk, x.DiaChi, x.STD, x.TrangThai, x.GioiTinh, x.ChucVu,x.Email);
            }
        }
      
        public AccountView GetDataFromUI()
        {
            _accountView = new AccountView()
            {
                Id =_id,
                TaiKhoan = tbx_Ten_TK.Text,
                MatKhau = tbx_MK.Text,

            };
            return _accountView;
        }
        public NhanVienView GetNhanVienFromUI()
        {
            _NhanVienView = new NhanVienView()
            {
                Id =_id,
                DiaChi = tbx_DiaChi.Text,
                TenNV = tbx_TenNhanVien.Text,
                MaNV = tbx_MaNhanVien.Text,
                TrangThai = rbtn_DangDiLam.Checked == true ? 1 : 0,
                GioiTinh = cmb_GioiTinh.Text,
                ChucVu = cmb_ChucVu.Text,
                STD = tbx_SoDienThoai.Text,
                HinhAnh=epbyte(pb_ca),
                Email=txt_email.Text,             
            };
            return _NhanVienView;
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

                foreach (char kitu2 in chuoiten)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public bool checktrung(string masp)
        {
            var r = _InhanVienSer.NvGetAll().Any(c => c.MaNV == masp);
            if (r == true) { return true; }
            return false;
        }
        public bool checktrungtk(string masp)
        {
            var r = _InhanVienSer.NvGetAll().Any(c => c.tk == masp);
            if (r == true) { return true; }
            return false;
        }
        public bool checkma(string ma2)
        {
            if (ma2 == ma) { return true; }
            else if (checktrung(ma2) == true) { return false; }
            else { return true; }
            return true;

        }
        public bool checktk(string ma2)
        {
            if (ma2 == taikh) { return true; }
            else if (checktrung(ma2) == true) { return false; }
            else { return true; }
            return true;

        }
        private bool kiemtrasdt(string chuoiCanKiemTra)
        {
            Regex chechdt = new Regex(@"^0");

            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoisdt)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }

            if (!chechdt.IsMatch(chuoiCanKiemTra))
            {
                return false;
            }
            /*else*/
            if (chuoiCanKiemTra.Length != 10)
            {
                return false;
            }

            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                if (tbx_MaNhanVien.Text.Trim() == "" || kiemtrakitu(tbx_MaNhanVien.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã nhân viên hoặc mã nhân viên có có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(tbx_MaNhanVien.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã nhân viên");
                    return;
                }
                else if (tbx_TenNhanVien.Text.Trim() == "" || kiemtraten(tbx_TenNhanVien.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên nhân viên hoặc tên nhân viên có kí tự đặc biệt");
                    return;
                }
                else if (tbx_Ten_TK.Text.Trim() == "" || kiemtrakitu(tbx_Ten_TK.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên tài khoản hoặc tên tài khoản có kí tự đặc biệt");
                    return;
                }
                else if (checktrungtk(tbx_Ten_TK.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng tài khoản");
                    return;
                }
                else if (pb_ca.Image == null)
                {

                    MessageBox.Show("Chọn ảnh cho nhân viên");
                    return;

                }
                else if (kiemtrasdt(tbx_SoDienThoai.Text) == false)
                {
                    MessageBox.Show("Bạn đang để trống SDT nhân viên hoặc SDT nhân viên sai định dạng");
                    return;
                }
                else if (!isEmail(txt_email.Text))
                {
                    MessageBox.Show("Email sai định dạng");
                    return;
                }
                else
                {
                    _NhanVienView = new NhanVienView();
                    _NhanVienView.Id = Guid.NewGuid();
                    _NhanVienView.DiaChi = tbx_DiaChi.Text;
                    _NhanVienView.TenNV = tbx_TenNhanVien.Text;
                    _NhanVienView.MaNV = tbx_MaNhanVien.Text;
                    _NhanVienView.TrangThai = rbtn_DangDiLam.Checked == true ? 1 : 0;
                    _NhanVienView.GioiTinh = cmb_GioiTinh.Text;
                    _NhanVienView.ChucVu = cmb_ChucVu.Text;
                    _NhanVienView.STD = tbx_SoDienThoai.Text;
                    _NhanVienView.HinhAnh = epbyte(pb_ca);
                    _NhanVienView.Email = txt_email.Text;
                    MessageBox.Show(_InhanVienSer.Add(_NhanVienView));
                    acc = new AccountView();
                    acc.Id = _NhanVienView.Id;
                    acc.TaiKhoan = tbx_Ten_TK.Text;
                    acc.MatKhau = tbx_MK.Text;
                    MessageBox.Show(_ItaiKhoanr.Add(acc));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                if (tbx_MaNhanVien.Text.Trim() == "" || kiemtrakitu(tbx_MaNhanVien.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã nhân viên hoặc mã nhân viên có có kí tự đặc biệt");
                    return;
                }
                else if (checkma(tbx_MaNhanVien.Text.Trim()) == false)
                {
                    MessageBox.Show("Trùng mã nhân viên");
                    return;
                }
                else if (tbx_TenNhanVien.Text.Trim() == "" || kiemtraten(tbx_TenNhanVien.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên nhân viên hoặc tên nhân viên có kí tự đặc biệt");
                    return;
                }
                else if (tbx_Ten_TK.Text.Trim() == "" || kiemtrakitu(tbx_Ten_TK.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên tài khoản hoặc tên tài khoản có kí tự đặc biệt");
                    return;
                }
                else if (checktk(tbx_Ten_TK.Text.Trim()) == false)
                {
                    MessageBox.Show("Trùng tài khoản");
                    return;
                }
                else if (pb_ca.Image == null)
                {

                    MessageBox.Show("Chọn ảnh cho nhân viên");
                    return;

                }
                else if (kiemtrasdt(tbx_SoDienThoai.Text) == false)
                {
                    MessageBox.Show("Bạn đang để trống SDT nhân viên hoặc SDT nhân viên sai định dạng");
                    return;
                }
                else if (!isEmail(txt_email.Text))
                {
                    MessageBox.Show("Email sai định dạng");
                    return;
                }
                else
                {
                    _NhanVienView.Id = _id;

                    _NhanVienView.DiaChi = tbx_DiaChi.Text;
                    _NhanVienView.TenNV = tbx_TenNhanVien.Text;
                    _NhanVienView.MaNV = tbx_MaNhanVien.Text;
                    _NhanVienView.TrangThai = rbtn_DangDiLam.Checked == true ? 1 : 0;
                    _NhanVienView.GioiTinh = cmb_GioiTinh.Text;
                    _NhanVienView.ChucVu = cmb_ChucVu.Text;
                    _NhanVienView.STD = tbx_SoDienThoai.Text;
                    _NhanVienView.HinhAnh = epbyte(pb_ca);
                    _NhanVienView.Email = txt_email.Text;
                    MessageBox.Show(_InhanVienSer.Update(_NhanVienView));
                    acc = new AccountView();
                    acc.Id = _id;
                    acc.TaiKhoan = tbx_Ten_TK.Text;
                    acc.MatKhau = tbx_MK.Text;
                    MessageBox.Show(_ItaiKhoanr.Update(acc));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_ItaiKhoanr.Delete(temp));
            LoadData();
        }

        private void dgird_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            acc = _ItaiKhoanr.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgird_TaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString()));

            tbx_MK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbx_Ten_TK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbx_MaNhanVien.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_TenNhanVien.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_SoDienThoai.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_ChucVu.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmb_GioiTinh.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbx_DiaChi.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[6].Value.ToString();

            _id = Guid.Parse(dgird_TaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString());
            ma = dgird_TaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            taikh = dgird_TaiKhoan.Rows[e.RowIndex].Cells[4].Value.ToString();
            var temp = _InhanVienSer.NvGetAll().FirstOrDefault(c => c.Id == _id);
            rbtn_DangDiLam.Checked = temp.TrangThai == 1 ? true : false;
            rbtn_DaNghi.Checked = temp.TrangThai == 0 ? true : false;
            pb_ca.Image = img(temp.HinhAnh);
            txt_email.Text = temp.Email;
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
            pb_ca.Image.Save(ms, pb_ca.Image.RawFormat);
            return ms.ToArray();
        }

        private void btn_ca_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn Hình Ảnh";
            opf.Filter = "Image Files (*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_ca.ImageLocation = opf.FileName;
            }
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            //dgird_TaiKhoan.ColumnCount = 1;
            //dgird_TaiKhoan.Columns[0].Name = "stt";
            //foreach (var item in _ItaiKhoanr.GetAll())
            //{
            //    dgird_TaiKhoan.Rows.Add(item.Id);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            dgird_TaiKhoan.ColumnCount = 12;
            dgird_TaiKhoan.Columns[0].Name = "Stt";
            dgird_TaiKhoan.Columns[1].Name = "ID";
            dgird_TaiKhoan.Columns[1].Visible = false;
            dgird_TaiKhoan.Columns[2].Name = "Tên NV";
            dgird_TaiKhoan.Columns[3].Name = "Mã NV";
            dgird_TaiKhoan.Columns[4].Name = "Tên TK";
            dgird_TaiKhoan.Columns[5].Name = "Mật khẩu";
            dgird_TaiKhoan.Columns[6].Name = "Địa chỉ";
            dgird_TaiKhoan.Columns[7].Name = "Số DT";
            dgird_TaiKhoan.Columns[8].Name = "Trạng thái";
            dgird_TaiKhoan.Columns[9].Name = "Giới tính";
            dgird_TaiKhoan.Columns[10].Name = "Chức vụ";
            dgird_TaiKhoan.Columns[11].Name = "Email";
            dgird_TaiKhoan.Rows.Clear();
            foreach (var x in _InhanVienSer.NvGetAll().Where(c => c.TenNV == tbx_TenNhanVien.Text || c.MaNV == tbx_MaNhanVien.Text))
            {
                dgird_TaiKhoan.Rows.Add(stt++, x.Id, x.TenNV, x.MaNV, x.tk, x.mk, x.DiaChi, x.STD, x.TrangThai, x.GioiTinh, x.ChucVu, x.Email);
            }
        }
    }
}
