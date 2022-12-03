using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace _3.PL.Views
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            loadcam();
            loadcmb();
        }

        private void loadcmb()
        {
            throw new NotImplementedException();
        }

        FilterInfoCollection asd;
        VideoCaptureDevice vn;

        

      
        private  void loadcam()
        {
            asd = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in asd)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
            vn = new VideoCaptureDevice(asd[comboBox1.SelectedIndex].MonikerString);
            vn.NewFrame += Vn_NewFrame;
            vn.Start();

        }

        private void Vn_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
