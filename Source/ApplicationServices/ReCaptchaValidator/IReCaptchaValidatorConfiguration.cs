using System;

namespace Junior.ApplicationServices.ReCaptchaValidator
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