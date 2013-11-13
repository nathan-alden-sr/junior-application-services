using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Junior.Common;

namespace Junior.ApplicationServices.ReCaptchaValidator
{
	public class ReCaptchaValidator : IReCaptchaValidator
	{
		private readonly IReCaptchaValidatorConfiguration _configuration;

		public ReCaptchaValidator(IReCaptchaValidatorConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		public async Task<ValidateResponseResult> ValidateResponse(IPAddress ipAddress, string challenge, string response)
		{
			ipAddress.ThrowIfNull("ipAddress");
			challenge.ThrowIfNull("challenge");
			response.ThrowIfNull("response");

			var content = new FormUrlEncodedContent(
				new[]
				{
					new KeyValuePair<string, string>("privatekey", _configuration.PrivateKey),
					new KeyValuePair<string, string>("remoteip", ipAddress.ToString()),
					new KeyValuePair<string, string>("challenge", challenge),
					new KeyValuePair<string, string>("response", response)
				});

			content.Headers.Add("User-Agent", _configuration.UserAgent);

			HttpResponseMessage responseMessage = await HttpClientSingleton.Instance.PostAsync(_configuration.Url, content);
			string responseContent = await responseMessage.Content.ReadAsStringAsync();
			string[] lines = responseContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

			return lines.Length > 0 && lines[0] == "true" ? ValidateResponseResult.Valid : ValidateResponseResult.Invalid;
		}
	}
}