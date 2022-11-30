using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        private byte[] epbyte(PictureBox pc)
        {
            MemoryStream ms= new MemoryStream();
            pcb_anh.Image.Save(ms, pcb_anh.Image.RawFormat);
            return ms.ToArray();
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn Hình Ảnh";
            opf.Filter = "Image Files (*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pcb_anh.ImageLocation = opf.FileName;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
