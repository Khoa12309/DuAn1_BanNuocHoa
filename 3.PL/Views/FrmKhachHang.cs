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
using System.Net;
using System.Net.Mail;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangSer _IkhachHangr;
        private KhachHangView _KhachHang_view;
        Guid _Id;
        public FrmKhachHang()
        {
            InitializeComponent();
            _KhachHang_view = new KhachHangView();
            _IkhachHangr = new KhachHangSer();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgird_KhachHang.ColumnCount = 7;
            dgird_KhachHang.Columns[0].Name = "Stt";
            dgird_KhachHang.Columns[1].Name = "ID";
            dgird_KhachHang.Columns[1].Visible = false;
            dgird_KhachHang.Columns[2].Name = "Ten khach hang";
            dgird_KhachHang.Columns[3].Name = "Ma khach hang";
            dgird_KhachHang.Columns[4].Name = "Gioi tinh";
            dgird_KhachHang.Columns[5].Name = "Dia chi";
            dgird_KhachHang.Columns[6].Name = "So dien thoai";
            dgird_KhachHang.Rows.Clear();
            foreach (var x in _IkhachHangr.KhGetAll())
            {
                dgird_KhachHang.Rows.Add(stt++, x.Id, x.TenKH, x.MaKH, x.GioiTinh, x.DiaChi, x.STD);
            }

        }
        public KhachHangView GetDataFromUI()
        {
            _KhachHang_view = new KhachHangView()
            {
                Id = Guid.NewGuid(),
                MaKH = tbx_MaKhachHang.Text,
                TenKH = tbx_TenKhachHang.Text,
                DiaChi = tbx_DiaChi.Text,
                STD = tbx_SoDienThoai.Text,
                GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nu"

            };
            return _KhachHang_view;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IkhachHangr.Add(GetDataFromUI()));
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _Id;
            MessageBox.Show(_IkhachHangr.Update(temp));
            LoadData();
        }

        private void btn_Datete_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _Id;
            MessageBox.Show(_IkhachHangr.Delete(temp));
            LoadData();
        }

        private void dgird_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = Guid.Parse(dgird_KhachHang.Rows[e.RowIndex].Cells[1].Value.ToString()); tbx_TenKhachHang.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[2].Value.ToString(); tbx_MaKhachHang.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            var Kh = _IkhachHangr.KhGetAll().FirstOrDefault(c => c.Id == _Id);

            if (Kh.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            if (Kh.GioiTinh == "Nu")
            {
                rbtn_Nu.Checked = true;
            }
            tbx_DiaChi.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbx_SoDienThoai.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

       
    }
}
