using System;
using System.Configuration;

namespace Junior.ApplicationServices.EmailSender
{
	public class EmailSenderConfigurationSection : ConfigurationSection
	{
		[ConfigurationProperty("username", IsRequired = true)]
		public string Username
		{
			get
			{
				return (string)this["username"];
			}
		}

		[ConfigurationProperty("password", IsRequired = true)]
		public string Password
		{
			get
			{
				return (string)this["password"];
			}
		}

		[ConfigurationProperty("fromAddress", IsRequired = true)]
		public string FromAddress
		{
			get
			{
				return (string)this["fromAddress"];
			}
		}

		[ConfigurationProperty("smtpHost", IsRequired = true)]
		public string SmtpHost
		{
			get
			{
				return (string)this["smtpHost"];
			}
		}

		[ConfigurationProperty("smtpPort", IsRequired = true)]
		public ushort SmtpPort
		{
			get
			{
				return (ushort)this["smtpPort"];
			}
		}

		[ConfigurationProperty("timeout", IsRequired = true)]
		public TimeSpan Timeout
		{
			get
			{
				return (TimeSpan)this["timeout"];
			}
		}

		[ConfigurationProperty("useSSL", IsRequired = true)]
		public bool UseSsl
		{
			get
			{
				return (bool)this["useSSL"];
			}
		}

		[ConfigurationProperty("fromAddressDisplayName", IsRequired = true)]
		public string FromAddressDisplayName
		{
			get
			{
				return (string)this["fromAddressDisplayName"];
			}
		}
	}
}