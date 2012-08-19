using System;
using System.Linq;
using System.Net.Mail;

using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Sends an email message.
	/// </summary>
	public class EmailSender : IEmailSender
	{
		private readonly IEmailSenderConfiguration _configuration;

		/// <summary>
		/// Initializes a new instance of the <see cref="EmailSender"/> class.
		/// </summary>
		/// <param name="configuration">Configuration necessary to send email messages.</param>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="configuration"/> is null.</exception>
		public EmailSender(IEmailSenderConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		/// <summary>
		/// Sends an email message.
		/// </summary>
		/// <param name="subject">The email's subject.</param>
		/// <param name="body">The email's body.</param>
		/// <param name="bodyFormat">The format of the email's body.</param>
		/// <param name="synchronization">Determines whether email messages are sent synchronously or asynchronously.</param>
		/// <param name="toAddresses">Email addresses to which the email will be sent.</param>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="toAddresses"/> is null.</exception>
		/// <exception cref="ArgumentException">Thrown when <paramref name="toAddresses"/> is empty.</exception>
		public void Send(string subject, string body, EmailBodyFormat bodyFormat, EmailSenderSynchronization synchronization, params EmailAddress[] toAddresses)
		{
			toAddresses.ThrowIfNull("toAddresses");
			if (!toAddresses.Any())
			{
				throw new ArgumentException("Must provide at least one to address.", "toAddresses");
			}

			var client = new SmtpClient(_configuration.SmtpHost, _configuration.SmtpPort)
				{
					Timeout = _configuration.Timeout.Milliseconds,
					EnableSsl = _configuration.UseSsl,
					Credentials = _configuration.Credentials
				};
			var message = new MailMessage
				{
					From = new MailAddress(_configuration.FromAddress, _configuration.FromAddressDisplayName)
				};

			foreach (MailAddress toMailAddress in toAddresses.Select(address => new MailAddress(address.ToString())))
			{
				message.To.Add(toMailAddress);
			}

			message.Subject = subject ?? "";
			message.Body = body ?? "";
			message.IsBodyHtml = bodyFormat == EmailBodyFormat.Html;

			switch (synchronization)
			{
				case EmailSenderSynchronization.Synchronous:
					client.Send(message);
					break;
				case EmailSenderSynchronization.Asynchronous:
					client.SendAsync(message, null);
					break;
				default:
					throw new ArgumentOutOfRangeException("synchronization");
			}
		}
	}
}