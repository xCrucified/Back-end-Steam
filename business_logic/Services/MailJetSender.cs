using business_logic.Helpers;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace business_logic.Services
{
    public class MailJetSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public MailJetSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailJetSettings? settings = _configuration.GetSection(nameof(MailJetSettings)).Get<MailJetSettings>();
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            MailjetClient client = new MailjetClient(settings.ApiKey, settings.ApiSecret);
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.FromEmail, "eexet17@gmail.com")
               .Property(Send.FromName, "Georgy")
               .Property(Send.Subject, subject)
               .Property(Send.TextPart, "You sup my boi")
               .Property(Send.HtmlPart, htmlMessage)
               .Property(Send.Recipients, new JArray {
                    new JObject {
                        {"Email", email}
                    }
               });

            await client.PostAsync(request);
        }
    }
}
