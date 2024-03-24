using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace FineJobsApp.Controller
{
    public class MailController
    {
        private static string email = "khanhandle257@gmail.com";
        private static string password = "ruenrxdmuhxjvshn";

        public static void SendEmail(string recipient, string subject, string body)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(email),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(recipient);

                smtpClient.Send(mailMessage);
                MessageBox.Show("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể gửi email. Lỗi: {ex.Message}");
            }
        }

    }
}
