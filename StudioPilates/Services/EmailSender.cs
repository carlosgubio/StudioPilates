using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using StudioPilates.Entities;
using System;
using System.Threading.Tasks;

namespace StudioPilates.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string textMessage, string messageHtml);
    }

    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfiguration;

        public EmailSender(IOptions<EmailConfiguration> emailConfiguration)
        {
            _emailConfiguration = emailConfiguration.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string textMessage, string messageHtml)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_emailConfiguration.SenderName, _emailConfiguration.SenderEmail));
            message.To.Add(MailboxAddress.Parse(email));

            message.Subject = _emailConfiguration.SenderName + " :: " + subject;
            var builder = new BodyBuilder { TextBody = textMessage, HtmlBody = messageHtml };
            message.Body = builder.ToMessageBody();

            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                //await client.ConnectAsync(EmailConfiguration.MailServer, _emailSettings.MailPort, _emailSettings.UseSsl).ConfigureAwait(false);
                await smtpClient.ConnectAsync(_emailConfiguration.EmailServerAddress).ConfigureAwait(false);
                //se o servidor requer autenticação para enviar
                await smtpClient.AuthenticateAsync(_emailConfiguration.SenderEmail, _emailConfiguration.Password).ConfigureAwait(false);
                await smtpClient.SendAsync(message).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
