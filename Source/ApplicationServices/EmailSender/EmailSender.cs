using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

using Junior.Common;

namespace Junior.ApplicationServices.EmailSender
{
	public class EmailSender : IEmailSender
	{
		private readonly IEmailSenderConfiguration _configuration;

		public EmailSender(IEmailSenderConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		public Task Send(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<EmailRecipient> recipients)
		{
			recipients.ThrowIfNull("recipients");

			recipients = recipients.ToArray();

			if (!recipients.Any())
			{
				throw new ArgumentException("Must provide at least one to recipient.", "recipients");
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

			foreach (EmailRecipient recipient in recipients)
			{
				switch (recipient.Type)
				{
					case EmailRecipientType.To:
						message.To.Add(new MailAddress(recipient.EmailAddress));
						break;
					case EmailRecipientType.CC:
						message.CC.Add(new MailAddress(recipient.EmailAddress));
						break;
					case EmailRecipientType.Bcc:
						message.Bcc.Add(new MailAddress(recipient.EmailAddress));
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}

			message.Subject = subject ?? "";
			message.Body = body ?? "";
			message.IsBodyHtml = bodyFormat == EmailBodyFormat.Html;

			return client.SendMailAsync(message);
		}

		public Task Send(string subject, string body, EmailBodyFormat bodyFormat, params EmailRecipient[] recipients)
		{
			return Send(subject, body, bodyFormat, (IEnumerable<EmailRecipient>)recipients);
		}

		public Task Send(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<string> toEmailAddresses)
		{
			toEmailAddresses.ThrowIfNull("toEmailAddresses");

			return Send(subject, body, bodyFormat, toEmailAddresses.Select(arg => new EmailRecipient(arg, EmailRecipientType.To)));
		}

		public Task Send(string subject, string body, EmailBodyFormat bodyFormat, params string[] toEmailAddresses)
		{
			return Send(subject, body, bodyFormat, (IEnumerable<string>)toEmailAddresses);
		}
	}
}