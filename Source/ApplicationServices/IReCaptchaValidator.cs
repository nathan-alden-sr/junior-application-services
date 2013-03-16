using System.Net;

namespace Junior.ApplicationServices
{
	public interface IReCaptchaValidator
	{
		bool ValidateResponse(IPAddress ipAddress, string challenge, string response);
	}
}