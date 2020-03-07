using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using DanubeJourney.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
using IEmailSender = DanubeJourney.Services.IEmailSender;

namespace DanubeJourney.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;
        private readonly IHostingEnvironment _env;

        public EmailSender(
            IOptions<EmailSettings> emailSettings,
            IHostingEnvironment env)
        {
            _emailSettings = emailSettings.Value;
            _env = env;
        }

        public  async Task SendEmailAsync(string name, string email, string subject, string txtMessage)
        {
            try
            {
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.Sender));

                mimeMessage.To.Add(new MailboxAddress(email));

                mimeMessage.Subject = subject;

                mimeMessage.Body = new TextPart("html")
                {
                    Text = txtMessage
                };

                using (var client = new SmtpClient ())
                {
                    client.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;

                    if (_env.IsDevelopment())
                    {
                        // The third parameter is useSSL (true if the client should make an SSL-wrapped
                        // connection to the server; otherwise, false).
                        await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, SecureSocketOptions.SslOnConnect);
                    }
                    else
                    {
                        await client.ConnectAsync(_emailSettings.MailServer);
                    }

                    // Note: only needed if the SMTP server requires authentication
                    await client.AuthenticateAsync(_emailSettings.Sender, _emailSettings.Password);

                    await client.SendAsync(mimeMessage);

                    await client.DisconnectAsync(true);
                }

            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
