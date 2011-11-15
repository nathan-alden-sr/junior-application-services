using System;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents configuration necessary to validate reCAPTCHA responses.
	/// </summary>
	public interface IReCaptchaValidatorConfiguration
	{
		/// <summary>
		/// Gets the URL for which reCAPTCHA is configured.
		/// </summary>
		Uri Url
		{
			get;
		}
		/// <summary>
		/// Gets the reCAPTCHA public key.
		/// </summary>
		string PublicKey
		{
			get;
		}
		/// <summary>
		/// Gets the reCAPTCHA private key.
		/// </summary>
		string PrivateKey
		{
			get;
		}
		/// <summary>
		/// Gets the value of the User-Agent header when validating responses.
		/// </summary>
		string UserAgent
		{
			get;
		}
		/// <summary>
		/// Gets the amount of time before a validation request times out.
		/// </summary>
		TimeSpan Timeout
		{
			get;
		}
	}
}