using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Services
{
        public class EmailSender : IEmailSender
        {
            public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
            {
                Options = optionsAccessor.Value;
            }

            public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

            public Task SendEmailAsync(string email, string subject, string message)
            {
                return Execute(Options.SendGridKey, subject, message, email);
            }

            public Task Execute(string apiKey, string subject, string message, string email)
            {
                var client = new SendGridClient(apiKey);
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("N01404730@unf.edu", "Y4C Survey Data Collection System"),
                    Subject = subject,
                    PlainTextContent = message,
                    HtmlContent = message
                };
                msg.AddTo(new EmailAddress(email));

                // Disable click tracking.
                // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
                msg.SetClickTracking(false, false);

                return client.SendEmailAsync(msg);
            }
        }
}
