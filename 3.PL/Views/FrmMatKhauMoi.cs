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
    public partial class FrmMatKhauMoi : Form
    {
        private AccountView _accountView;
        private IAccountSer _accountSer;
        public FrmMatKhauMoi()
        {
            _accountSer = new AccountSer();
            _accountView = new AccountView();
            InitializeComponent();
        }

       
        void registerEnvent()
        {
            lbl_Closer.Click += lbl_Closer_Click;
        }
        private void lbl_Closer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dmk_Click(object sender, EventArgs e)
        {
            var x = _accountSer.GetAll().FirstOrDefault(c => c.TaiKhoan == txt_taikhoan.Text);
            if (_accountSer.GetAll().Any(c => c.TaiKhoan == txt_taikhoan.Text) == false)
            {
                MessageBox.Show("Không tìm thấy tài khoản ", "Thông báo");
                return;
            }
            else if (txt_matkhau.Text != x.MatKhau)
            {

                MessageBox.Show("Mật khẩu không chính xác", "Thông báo");
                return;
            }
            else if (txt_matkhaumoi.Text == x.MatKhau)
            {
                MessageBox.Show("Mật khẩu mới đang giống mật khẩu cũ", "Thông báo");
                return;
            }
            else if (txt_xacnhan.Text != txt_matkhaumoi.Text)
            {

                MessageBox.Show("Mật khẩu mới không chính xác", "Thông báo");
                return;
            }
            else
            {
                DialogResult dia = MessageBox.Show("Bạn muốn thay đổi thành mật khẩu này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    x.MatKhau = txt_matkhaumoi.Text;
                    MessageBox.Show(_accountSer.Update(x));

                }
                else
                {
                    return;
                }
            }
        }
    }
}
