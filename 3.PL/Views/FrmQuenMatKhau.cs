using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmQuenMatKhau : Form
    {
        private IAccountSer _IaccountSer;

        private INhanVienSer _InhanVien;

        private FrmDangNhap dangNhap;
        public FrmQuenMatKhau()
        {
             dangNhap = new FrmDangNhap();
             dangNhap.Show();
            _IaccountSer = new AccountSer();
            _InhanVien = new NhanVienSer();
             InitializeComponent();
        }
        public bool Check()
        {

            var email = _InhanVien.NvGetAll().FindIndex(c => c.Email == txt_gmail.Text.Trim());

            var Nhanvien = _InhanVien.NvGetAll().FindIndex(c => c.STD == txt_sdt.Text.Trim());

            if (Nhanvien == -1 || email == -1)
            {
                MessageBox.Show("không tìm thấy sô điện thoại và email này");
                return false;
            }
            return true;
        }

        private void btn_xacdinh_Click(object sender, EventArgs e)
        {
            var email2 = _InhanVien.NvGetAll().FirstOrDefault(c => c.Email == txt_gmail.Text.Trim());
            var MatKhau = _IaccountSer.GetAll().FirstOrDefault(c => c.Id == email2.Id);
            if (Check() == true)
            {
                string from = "dungndph20833@fpt.edu.vn";
                string pass = "nguyendungdeptrai2k3";
                string to = txt_gmail.Text.Trim();

                MailMessage mail = new MailMessage();
                mail.To.Add(to);

                mail.From = new MailAddress(from);
                mail.Subject = "Mật khẩu cũ";
                mail.Body = "Tên tài khoản:  " + MatKhau.TaiKhoan + "\t" + "Mật khẩu cũ của bạn là: " + MatKhau.MatKhau;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.TargetName = "KK";
                try
                {
                    smtp.Send(mail);
                    DialogResult dialogResult = MessageBox.Show("Gửi thành công,bạn có muốn thay đổi mật không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FrmMatKhauMoi matKhauMoi = new FrmMatKhauMoi();
                        matKhauMoi.ShowDialog();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
