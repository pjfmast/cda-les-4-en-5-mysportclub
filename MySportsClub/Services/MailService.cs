using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using MySportsClub.Models;

namespace MySportsClub.Services {
    // todo lesson 6-06b: IMailService implementation
    public class MailService : IMailService {
        private readonly MailSettings _mailSettings;

        /* The IOptions service is used to bind strongly types options class to 
         * configuration section and registers it to the Asp.Net Core Dependency Injection Service Container as singleton lifetime. 
         * It exposes a Value property which contains your configured TOptions class.
         */
        public MailService(IOptions<MailSettings> mailSettings) {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendMailAsync(MailRequest mailRequest) {
            // construct email:
            MimeMessage email = new() {
                Sender = MailboxAddress.Parse(_mailSettings.Mail)
            };
            email.To.Add(MailboxAddress.Parse(mailRequest.To));
            email.Subject = mailRequest.Subject;

            BodyBuilder builder = new();
            builder.HtmlBody = mailRequest.Body;

            // add optional attachments:
            if (mailRequest.Attachments != null) {
                byte[] fileBytes;
                foreach (var file in mailRequest.Attachments) {
                    if (file.Length > 0) {
                        using (var ms = new MemoryStream()) {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }
            }
            email.Body = builder.ToMessageBody();

            // use SmtpClient for sending the constructed email
            using var smtpClient = new SmtpClient();
            // use also Transport Layer Security (TLS)
            smtpClient.Connect(_mailSettings.Host, _mailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
            smtpClient.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtpClient.SendAsync(email);  
            await smtpClient.DisconnectAsync(true);
        }
    }
}
