using System;
using System.IO;
using System.Net;

using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Validate reCAPTCHA responses.
	/// </summary>
	public class ReCaptchaValidator : IReCaptchaValidator
	{
		private readonly IReCaptchaValidatorConfiguration _configuration;
		private readonly IUrlEncoder _urlEncoder;

		/// <summary>
		/// Initializes a new instance of the <see cref="ReCaptchaValidator"/> class.
		/// </summary>
		/// <param name="configuration">Configuration necessary to send email messages.</param>
		/// <param name="urlEncoder">A URL encoder.</param>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="configuration"/> is null.</exception>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="urlEncoder"/> is null.</exception>
		public ReCaptchaValidator(IReCaptchaValidatorConfiguration configuration, IUrlEncoder urlEncoder)
		{
			configuration.ThrowIfNull("configuration");
			urlEncoder.ThrowIfNull("urlEncoder");

			_configuration = configuration;
			_urlEncoder = urlEncoder;
		}

		/// <summary>
		/// Validates a reCAPTCHA response.
		/// </summary>
		/// <param name="ipAddress">The remote IP address.</param>
		/// <param name="challenge">The challenge string.</param>
		/// <param name="response">The user's response.</param>
		/// <returns>true if the user's response is correct; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="ipAddress"/> is null.</exception>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="challenge"/> is null.</exception>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="response"/> is null.</exception>
		public bool ValidateResponse(IPAddress ipAddress, string challenge, string response)
		{
			ipAddress.ThrowIfNull("ipAddress");
			challenge.ThrowIfNull("challenge");
			response.ThrowIfNull("response");

			var webRequest = (HttpWebRequest)WebRequest.Create(_configuration.Url);

			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.ProtocolVersion = HttpVersion.Version10;
			webRequest.Timeout = (int)_configuration.Timeout.TotalMilliseconds;
			webRequest.Method = "POST";
			webRequest.UserAgent = _configuration.UserAgent;

			var writer = new StreamWriter(webRequest.GetRequestStream());

			writer.Write(
				"privatekey={0}&remoteip={1}&challenge={2}&response={3}",
				_urlEncoder.Encode(_configuration.PrivateKey),
				_urlEncoder.Encode(ipAddress.ToString()),
				_urlEncoder.Encode(challenge),
				_urlEncoder.Encode(response));
			writer.Close();

			WebResponse webResponse = webRequest.GetResponse();
			var reader = new StreamReader(webResponse.GetResponseStream());
			string[] results = reader.ReadToEnd().Split(new[] { "\n", "\\n" }, StringSplitOptions.RemoveEmptyEntries);

			reader.Close();

			return Boolean.Parse(results[0]);
		}
	}
}