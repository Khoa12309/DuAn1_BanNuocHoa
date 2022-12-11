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
    public partial class FrmThongBao : Form
    {
        public FrmThongBao()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            string from, to, pass, contents;
            from = txt_mailnguoigui.Text.Trim();
            to = txt_mailnguoinhan.Text.Trim();
            pass = txt_mk.Text.Trim();
            MailMessage mail = new MailMessage();
            mail.To.Add(to);

            mail.From = new MailAddress(from);
            mail.Subject = txt_td.Text;
            mail.Body = txt_nd.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.TargetName = "KK";
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
