using System.Net;
using System.Threading.Tasks;

namespace Junior.ApplicationServices.ReCaptchaValidator
{
	public interface IReCaptchaValidator
	{
		Task<ValidateResponseResult> ValidateResponse(IPAddress ipAddress, string challenge, string response);
	}
}