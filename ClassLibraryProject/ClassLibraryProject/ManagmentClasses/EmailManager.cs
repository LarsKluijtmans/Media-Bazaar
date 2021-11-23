using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class EmailManager
    {
        public void Email(string Password, string Username, string Email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("MediaBazaar.HQ@gmail.com", "MediaBazaar21"),
                EnableSsl = true,
            };

            StringBuilder message = new StringBuilder();

            message.Append(" <h1>Here is your acount information.</h1>");
            message.AppendLine("<p>Here is your acount information.</p>");
            message.AppendLine("<p>You can use these in the diferent mediabazaar apps and websites.</p>");
            message.AppendLine($"<p>                Username: {Username}</p>");
            message.AppendLine($"<p>                password: {Password}</p>");
            message.AppendLine("<p> Please change your password on i474883core.venus.fhict.nl </p>");
            message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                Subject = "Mediabazaar acount information",
                Body = message.ToString(),
                IsBodyHtml = true,
            };
            mailMessage.To.Add(Email);

            smtpClient.Send(mailMessage);
        }
    }
}
