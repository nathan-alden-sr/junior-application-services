using System;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents configuration necessary to validate reCAPTCHA responses.
	/// </summary>
	public interface IReCaptchaValidatorConfiguration
	{
		/// <summary>
		/// The URL for which reCAPTCHA is configured.
		/// </summary>
		Uri Url
		{
			get;
		}
		/// <summary>
		/// The reCAPTCHA public key.
		/// </summary>
		string PublicKey
		{
			get;
		}
		/// <summary>
		/// The reCAPTCHA private key.
		/// </summary>
		string PrivateKey
		{
			get;
		}
		/// <summary>
		/// The value of the User-Agent header when validating responses.
		/// </summary>
		string UserAgent
		{
			get;
		}
		/// <summary>
		/// The amount of time before a validation request times out.
		/// </summary>
		TimeSpan Timeout
		{
			get;
		}
	}
}