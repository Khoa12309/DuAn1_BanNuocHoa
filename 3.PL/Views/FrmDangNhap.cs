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
        private Guid _id;
     
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
                _id = _Iser.GetAll().FirstOrDefault(c => c.TaiKhoan ==txt_Tk.Text).Id;
                FrmMain frm = new FrmMain();   
               frm._idnv=getid();
                frm.ShowDialog();
            }
            else if (_Iser.check(getfrm()) == 2)
            {
                _id = _Iser.GetAll().FirstOrDefault(c => c.TaiKhoan == txt_Tk.Text).Id;
                FrmMain frm = new FrmMain();              
                frm._idnv = getid();
                frm.check("Nhân viên");
                frm.ShowDialog();
            }
            else
            MessageBox.Show("Tài Khoản hoạc mật khẩu không đúng ");
            this.Hide();
        }
      
        public Guid getid()
        {
            return _id;
        }
        private void txt_Tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #region Event
        void registerEnvent()
        {
            lbl_closer.Click += lbl_closer_Click;
        }
        private void lbl_closer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
