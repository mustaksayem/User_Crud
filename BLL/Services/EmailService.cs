using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmailService
    {
        public bool SendEmail(string recipient, string subject, string body)
        {
            try
            {
                // Create a MailMessage object
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(recipient);
                mailMessage.Subject = subject;
                mailMessage.Body = body;



                // Create an SmtpClient object
                SmtpClient smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,



                    // Set your credentials
                    Credentials = new NetworkCredential("mustakhasansayem@gmail.com", "eashoyjtnlopimad")
                };



                // Send the email
                smtpClient.Send(mailMessage);



                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                Console.WriteLine(ex.ToString());

                return false;
            }
        }
    }
}
