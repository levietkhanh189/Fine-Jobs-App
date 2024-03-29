﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace FineJobsApp.Controller
{
    public class MailController
    {
        private static string email = "khanhandle257@gmail.com";
        private static string password = "ruenrxdmuhxjvshn";

        public static int GenerateRandomCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

        public static int SendEmailCode(string recipient)
        {
            string subject = "Mã xác nhận tài khoản";
            int code = GenerateRandomCode();
            string body = $"Mã xác nhận của bạn là: {code}";
            SendEmail(recipient, subject, body);
            return code;
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể gửi email. Lỗi: {ex.Message}");
            }
        }

        public static void OpenGmailWithRecipient(string recipientEmail)
        {
            string subject = Uri.EscapeDataString("Tiêu đề của email"); // Tiêu đề email
            string body = Uri.EscapeDataString("Nội dung của email."); // Nội dung email

            string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={recipientEmail}&su={subject}&body={body}";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = gmailUrl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở Gmail. Lỗi: {ex.Message}");
            }

        }

    }
}
