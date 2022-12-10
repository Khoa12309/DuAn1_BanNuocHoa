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
        public FrmMatKhauMoi()
        {
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
    }
}
