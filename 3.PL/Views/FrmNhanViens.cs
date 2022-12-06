using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private List<string> ChucVus = new List<string>() { "NV bán hàng", "NV thủ quỹ", "NV chăm sóc khách hàng" };
        public FrmTaiKhoan()
        {
            InitializeComponent();
            _ItaiKhoanr = new AccountSer();
            _accountView = new AccountView();
            _InhanVienSer = new NhanVienSer();
            _NhanVienView = new NhanVienView();
            LoadData();
            GioiTinhh();
            ChucVu();
        }
        public void LoadData()
        {
            int stt = 1;
            dgird_TaiKhoan.ColumnCount = 11;
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
            dgird_TaiKhoan.Rows.Clear();
            foreach (var x in _ItaiKhoanr.GetAll())
            {

                dgird_TaiKhoan.Rows.Add(stt++, x.Id, _NhanVienView.TenNV, _NhanVienView.MaNV, x.TaiKhoan, x.MatKhau, _NhanVienView.DiaChi, _NhanVienView.STD, _NhanVienView.TrangThai, x.GioiTinh, x.ChucVu);
                _NhanVienView = _InhanVienSer.NvGetAll().Find(c => c.Id == x.Id);
            }

        }

        public void GioiTinhh()
        {
            foreach (var x in GioiTinh)
            {
                cmb_GioiTinh.Items.Add(x);
            }
            cmb_GioiTinh.SelectedIndex = 0;
        }
        public void ChucVu()
        {
            foreach (var x in ChucVus)
            {
                cmb_ChucVu.Items.Add(x);
            }
            cmb_ChucVu.SelectedIndex = 0;
        }


        public AccountView GetDataFromUI()
        {
            _accountView = new AccountView()
            {
                Id = Guid.NewGuid(),
                TaiKhoan = tbx_Ten_TK.Text,
                MatKhau = tbx_MK.Text,

            };
            return _accountView;
        }
        public NhanVienView GetNhanVienFromUI()
        {
            _NhanVienView = new NhanVienView()
            {
                Id = _accountView.Id,
                DiaChi = tbx_DiaChi.Text,
                TenNV = tbx_TenNhanVien.Text,
                MaNV = tbx_MaNhanVien.Text,
                TrangThai = rbtn_DangDiLam.Checked == true ? "Đang đi làm" : "Đã nghỉ",
                GioiTinh = cmb_GioiTinh.Text,
                ChucVu = cmb_ChucVu.Text,
                STD = tbx_SoDienThoai.Text
            };
            return _NhanVienView;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ItaiKhoanr.Add(GetDataFromUI()));
            _InhanVienSer.Add(GetNhanVienFromUI());
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            var temp1 = GetNhanVienFromUI();
            temp1.Id = _id;
            temp.Id = _id;
            temp1.TenNV = tbx_TenNhanVien.Text;
            MessageBox.Show(_ItaiKhoanr.Update(temp));
            _InhanVienSer.Update(temp1);
            LoadData();
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
            tbx_MK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbx_Ten_TK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbx_MaNhanVien.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_TenNhanVien.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_SoDienThoai.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_ChucVu.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmb_GioiTinh.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbx_DiaChi.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[6].Value.ToString();

            _id = Guid.Parse(dgird_TaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString());
            var temp = _InhanVienSer.NvGetAll().FirstOrDefault(c => c.Id == _id);
            if (temp.TrangThai == "Đang đi làm")
            {
                rbtn_DangDiLam.Checked = true;

            }
            if (temp.TrangThai == "Đã nghỉ")
            {
                rbtn_DaNghi.Checked = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
