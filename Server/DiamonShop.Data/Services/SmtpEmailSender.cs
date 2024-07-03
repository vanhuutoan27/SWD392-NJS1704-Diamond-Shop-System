using DiamonShop.Core.Models.auth;
using DiamonShop.Core.services;
using MailKit.Net.Smtp;
using MimeKit;

namespace DiamonShop.Data.Services
{
    public class SmtpEmailSender : IEmailSender
    {

        private readonly SmtpOptions _smtpOptions;
        public SmtpEmailSender(SmtpOptions emailOptions)
        {
            _smtpOptions = emailOptions;
        }

        public async Task SendEmailAsync(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }
        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("email", _smtpOptions.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };

            return emailMessage;
        }
        private void Send(MimeMessage mailMessage)
        {
            using var client = new SmtpClient();
            try
            {
                client.Connect(_smtpOptions.SmtpServer, _smtpOptions.Port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(_smtpOptions.Username, _smtpOptions.Password);

                client.Send(mailMessage);
            }
            catch
            {
                //log an error message or throw an exception or both.
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
