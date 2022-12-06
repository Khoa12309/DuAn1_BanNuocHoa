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
        Guid _id;
        public FrmTaiKhoan()
        {
            InitializeComponent();
            _ItaiKhoanr = new AccountSer();
            _accountView = new AccountView();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgird_TaiKhoan.ColumnCount = 4;
            dgird_TaiKhoan.Columns[0].Name = "Stt";
            dgird_TaiKhoan.Columns[1].Name = "ID";
            dgird_TaiKhoan.Columns[1].Visible = false;
            dgird_TaiKhoan.Columns[2].Name = "Ten tai khoan";
            dgird_TaiKhoan.Columns[3].Name = "Mat khau";
            dgird_TaiKhoan.Rows.Clear();
            foreach (var x in _ItaiKhoanr.GetAll())
            {
                dgird_TaiKhoan.Rows.Add(stt++, x.Id, x.TaiKhoan, x.MatKhau);
            }

        }
        public AccountView GetDataFromUI()
        {
            _accountView = new AccountView()
            {
                Id = Guid.NewGuid(),
                TaiKhoan = tbx_Ten_TK.Text,
                MatKhau = tbx_MK.Text
            };
            return _accountView;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ItaiKhoanr.Add(GetDataFromUI()));
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_ItaiKhoanr.Update(temp));
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
            tbx_MK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_Ten_TK.Text = dgird_TaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
           _id = Guid.Parse( dgird_TaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
