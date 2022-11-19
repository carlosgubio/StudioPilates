using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace StudioPilates.Services
{
    public class SendGridSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subjects, string textMessage, string messageHtml)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("institutomovimentoconsciente@gmail.com", "Instituto Movimento Consciente");
            var subject = subjects;
            var to = new EmailAddress(email);
            var plainTextContent = textMessage;
            var htmlContent = messageHtml;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
