using System;
using System.Net;

using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents configuration necessary to send email messages.
	/// </summary>
	public interface IEmailSenderConfiguration
	{
		/// <summary>
		/// Gets the hostname of an SMTP server.
		/// </summary>
		string SmtpHost
		{
			get;
		}
		/// <summary>
		/// Gets a port for SMTP communication.
		/// </summary>
		int SmtpPort
		{
			get;
		}
		/// <summary>
		/// Gets a timeout for sending email messages.
		/// </summary>
		TimeSpan Timeout
		{
			get;
		}
		/// <summary>
		/// Gets a value indicating if SSL will be used when sending email messages.
		/// </summary>
		bool UseSsl
		{
			get;
		}
		/// <summary>
		/// Gets the credentials to use when authenticating with the SMTP server.
		/// </summary>
		NetworkCredential Credentials
		{
			get;
		}
		/// <summary>
		/// Gets the email address sending the email messages.
		/// </summary>
		EmailAddress FromAddress
		{
			get;
		}
		/// <summary>
		/// Gets the display name of the email address sending the email messages.
		/// </summary>
		string FromAddressDisplayName
		{
			get;
		}
	}
}