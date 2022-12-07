using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace _3.PL.Views
{
    public partial class Gmail : Form
    {
        public Gmail()
        {
            InitializeComponent();
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            string from, to, pass, contents;
            from = tbx_NguoiGui.Text.Trim();
            to = tbx_NguoiNhan.Text.Trim();
            pass = tbx_matKhau.Text.Trim();
            contents = c.Text;
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Thư mời bạn nhận lương";
            mail.Body = tbx_NoiDung.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
