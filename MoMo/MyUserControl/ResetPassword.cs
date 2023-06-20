using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.Model;

namespace MoMo.MyUserControl
{
    public partial class ResetPassword : UserControl
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        public void sendMail(string emailAddress)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("tdao67777@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "wmtuxksqwtvgnpqx");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(emailAddress));
            mail.IsBodyHtml = true;
            mail.Subject = "Đổi lại mật khẩu ứng dụng MoMo";
            mail.Body = "Mật khẩu mới là: 123456. Hãy đổi lại khi đăng nhập vào ứng dụng.";

            string phoneNumber = textBox1.Text;
            using (UserDbContext db = new())
            {
                User? user = db.Users.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefault();
                if (user != null)
                {
                    user.Password = "123456";
                    db.Users.Update(user);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Địa chỉ email không đúng với SĐT đã đăng kí!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            smtp.Send(mail);
            MessageBox.Show("Đặt lại mật khẩu thành công! Hãy kiểm tra mật khẩu mới trong e-mail", "Thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBox1.Text;
            using (UserDbContext db = new())
            {
                User? user = db.Users.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefault();
                if (user != null)
                {
                    sendMail(user.Email);
                }
                else
                {
                    MessageBox.Show("Địa chỉ email không đúng với SĐT đã đăng kí!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
