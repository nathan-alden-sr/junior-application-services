using System;
using System.Net;

using Junior.Common;

namespace Junior.ApplicationServices
{
	public interface IEmailSenderConfiguration
	{
		string SmtpHost
		{
			get;
		}
		int SmtpPort
		{
			get;
		}
		TimeSpan Timeout
		{
			get;
		}
		bool UseSsl
		{
			get;
		}
		NetworkCredential Credentials
		{
			get;
		}
		EmailAddress FromAddress
		{
			get;
		}
		string FromAddressDisplayName
		{
			get;
		}
	}
}