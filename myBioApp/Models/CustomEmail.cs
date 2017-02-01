using System;
using System.Text;

namespace myBioApp.Models
{
    public class CustomEmail
    {
        public static void SendEmailNotification(Email email, string receiver)
        {
            try
            {

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                mail.From = new System.Net.Mail.MailAddress("olix.tech@gmail.com");
                mail.To.Add(receiver);
                mail.Subject = "myBio App Message from " + email.Email_Str.ToString();
                mail.Body = email.Message;
                mail.BodyEncoding = Encoding.UTF8;

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("olix.tech@gmail.com", "anonym0u$1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}