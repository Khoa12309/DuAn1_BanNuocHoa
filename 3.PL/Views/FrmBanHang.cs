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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace _3.PL.Views
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            loadcam();
            // loadcmb();
        }

        private void loadcmb()
        {
            throw new NotImplementedException();
        }

        FilterInfoCollection asd;
        VideoCaptureDevice vn;




        private void loadcam()
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
            //Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //pictureBox1.Image = bitmap;
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (vn.IsRunning)
            {
                vn.Stop();
            }
        }
        private static byte[] ToByteArray(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);

              
                if (result != null)
                {
                    button2.Text = result.ToString();

                }
                else MessageBox.Show("null1");

            }
            else MessageBox.Show("null");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
