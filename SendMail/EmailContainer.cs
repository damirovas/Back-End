using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public delegate void EmailSender();
    internal class EmailContainer
    {
        public event EmailSender emailSender;
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email}-a mesaj gonderildi");
            OnEmailSender(email);
        }
        protected virtual void OnEmailSender(string email)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("sdamirova2004@gamil.com");
            mailMessage.Subject = "Test Email";
            mailMessage.Body = $"This is a test mail to {email} ";
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.UseDefaultCredentials = true;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential();
            emailSender?.Invoke();         
        }
    }
}
