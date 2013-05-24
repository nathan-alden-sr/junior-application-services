using System;
using System.Net;

namespace Junior.ApplicationServices
{
	public interface IEmailSenderConfiguration
	{
		string SmtpHost
		{
			get;
		}
		ushort SmtpPort
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
		string FromAddress
		{
			get;
		}
		string FromAddressDisplayName
		{
			get;
		}
	}
}