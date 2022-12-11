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
    public partial class FrmKhac : Form
    {
        public FrmKhac()
        {
            InitializeComponent();
        }

        private void btn_loaisp_Click(object sender, EventArgs e)
        {
            FrmLoaiSp lsp=new FrmLoaiSp();
            lsp.ShowDialog();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh=new FrmKhachHang();
            kh.ShowDialog();
        }

        private void btn_hsx_Click(object sender, EventArgs e)
        {
            FrmHangSp hsp=new FrmHangSp();
            hsp.ShowDialog();
        }
    }
}
