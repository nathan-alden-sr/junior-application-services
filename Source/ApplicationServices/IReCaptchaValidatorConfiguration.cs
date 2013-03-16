using System;

namespace Junior.ApplicationServices
{
	public interface IReCaptchaValidatorConfiguration
	{
		Uri Url
		{
			get;
		}
		string PublicKey
		{
			get;
		}
		string PrivateKey
		{
			get;
		}
		string UserAgent
		{
			get;
		}
		TimeSpan Timeout
		{
			get;
		}
	}
}