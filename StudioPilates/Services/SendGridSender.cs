using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace StudioPilates.Services
{
    public class SendGridSender : IEmailSender
    {        
        public async Task SendEmailAsync(string email, string subject, string textMessage, string messageHtml)
        {
            var apiKey = "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";
            var customer = new SendGridClient(apiKey);
            var from = new EmailAddress("emailquitandaonline@gmail.com", "Quitanda Online");
            var subjects = subject;
            var to = new EmailAddress(email);
            var plainTextContent = textMessage;
            var htmlContent = messageHtml;
            var msg = MailHelper.CreateSingleEmail(from, to, subjects, plainTextContent, htmlContent);
            var response = await customer.SendEmailAsync(msg);
        }        
    }
}
