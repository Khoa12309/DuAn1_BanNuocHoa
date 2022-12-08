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
            loadfrm();
        }

        private void loadfrm()
        {
            int stt = 1;
            Type type = typeof(HoaDon);
           dataGridView1.ColumnCount = 4;//Hiển thị bao nhiểu cột tự cấu hình
            dataGridView1.Rows.Clear();
            foreach (var x in _Iser.GetAll())
            {
                dataGridView1.Rows.Add(stt++,x.TaiKhoan,x.MatKhau,x.ChucVu);
            }
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
            FrmMain frm = new FrmMain();
            frm.ShowDialog();
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
