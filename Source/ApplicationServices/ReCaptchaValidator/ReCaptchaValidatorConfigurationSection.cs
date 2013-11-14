using System;
using System.Configuration;

namespace Junior.ApplicationServices.ReCaptchaValidator
{
	public class ReCaptchaValidatorConfigurationSection : ConfigurationSection
	{
		[ConfigurationProperty("url", IsRequired = true)]
		public Uri Url
		{
			get
			{
				return (Uri)this["url"];
			}
		}

		[ConfigurationProperty("publicKey", IsRequired = true)]
		public string PublicKey
		{
			get
			{
				return (string)this["publicKey"];
			}
		}

		[ConfigurationProperty("privateKey", IsRequired = true)]
		public string PrivateKey
		{
			get
			{
				return (string)this["privateKey"];
			}
		}

		[ConfigurationProperty("userAgent", IsRequired = true, DefaultValue = "reCAPTCHA/Junior")]
		public string UserAgent
		{
			get
			{
				return (string)this["userAgent"];
			}
		}

		[ConfigurationProperty("enabled", IsRequired = false, DefaultValue = false)]
		public bool Enabled
		{
			get
			{
				return (bool)this["enabled"];
			}
		}
	}
}