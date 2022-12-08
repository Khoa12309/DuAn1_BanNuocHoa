using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmHoaDon : Form
    {
        private IKhuyenMaiSer _Ikmser;
        public FrmHoaDon()
        {
            InitializeComponent();
            _Ikmser = new KhuyenMaiSer();
        }

        private void dgrid_hd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
