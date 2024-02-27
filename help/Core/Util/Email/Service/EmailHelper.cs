using Core.Util.Email.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Util.Email.Service
{
    public class EmailHelper : IEmailHelper
    {
        private readonly EmailSettings _emailSettings;


        public EmailHelper(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<bool> SendEmail(
            string userEmail, 
            string message, 
            string subject)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_emailSettings.Adress);
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = message;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(_emailSettings.Adress, _emailSettings.Password);

            client.Host = _emailSettings.Host;
            client.Port = _emailSettings.Port;
            client.EnableSsl = _emailSettings.EnableSSl;
            client.UseDefaultCredentials = _emailSettings.UseDefaultCredentials;

            try
            {
                await client.SendMailAsync(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
