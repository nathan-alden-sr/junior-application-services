using System.Net;

namespace Junior.ApplicationServices.ReCaptchaValidator
{
	public interface IReCaptchaValidator
	{
		bool ValidateResponse(IPAddress ipAddress, string challenge, string response);
	}
}