using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

using Junior.Common;

namespace Junior.ApplicationServices
{
	public class EmailSender : IEmailSender
	{
		private readonly IEmailSenderConfiguration _configuration;

		public EmailSender(IEmailSenderConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		public async Task Send(string subject, string body, EmailBodyFormat bodyFormat, params string[] toAddresses)
		{
			toAddresses.ThrowIfNull("toAddresses");
			if (!toAddresses.Any())
			{
				throw new ArgumentException("Must provide at least one to address.", "toAddresses");
			}

			var client = new SmtpClient(_configuration.SmtpHost, _configuration.SmtpPort)
				{
					Timeout = (int)_configuration.Timeout.TotalMilliseconds,
					EnableSsl = _configuration.UseSsl,
					Credentials = _configuration.Credentials
				};
			var message = new MailMessage
				{
					From = new MailAddress(_configuration.FromAddress, _configuration.FromAddressDisplayName)
				};

			foreach (MailAddress toMailAddress in toAddresses.Select(address => new MailAddress(address)))
			{
				message.To.Add(toMailAddress);
			}

			message.Subject = subject ?? "";
			message.Body = body ?? "";
			message.IsBodyHtml = bodyFormat == EmailBodyFormat.Html;

			await client.SendMailAsync(message);
		}
	}
}