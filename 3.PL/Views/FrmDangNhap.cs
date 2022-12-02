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
    public partial class FrmDangNhap : Form
    {
        private IAccountSer _Iser;
        public FrmDangNhap()
        {
            InitializeComponent();
            _Iser=new AccountSer();
 
        }

      

        private AccountView getfrm()
        {
            AccountView view = new AccountView();
            view = new AccountView() {
             MatKhau = txt_Mk.Text,
            TaiKhoan=txt_Tk.Text
            };
            return view;
        }
        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (_Iser.check(getfrm()) == 1)
            {
                MessageBox.Show("Tài Khoản adim");
            
            }else if (_Iser.check(getfrm()) == 2)
            {
                MessageBox.Show("Tài Khoản user");
            
            }
            else
            MessageBox.Show("Tài Khoản 0 ");

        }

        private void txt_Tk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
