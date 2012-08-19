using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to send an email message.
	/// </summary>
	public interface IEmailSender
	{
		/// <summary>
		/// Sends an email message.
		/// </summary>
		/// <param name="subject">The email's subject.</param>
		/// <param name="body">The email's body.</param>
		/// <param name="bodyFormat">The format of the email's body.</param>
		/// <param name="synchronization">Determines whether email messages are sent synchronously or asynchronously.</param>
		/// <param name="toAddresses">Email addresses to which the email will be sent.</param>
		void Send(string subject, string body, EmailBodyFormat bodyFormat, EmailSenderSynchronization synchronization, params EmailAddress[] toAddresses);
	}
}