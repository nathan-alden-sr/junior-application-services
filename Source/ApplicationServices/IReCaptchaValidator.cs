using System.Net;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to validate reCAPTCHA responses.
	/// </summary>
	public interface IReCaptchaValidator
	{
		/// <summary>
		/// Validates a reCAPTCHA response.
		/// </summary>
		/// <param name="ipAddress">The remote IP address.</param>
		/// <param name="challenge">The challenge string.</param>
		/// <param name="response">The user's response.</param>
		/// <returns>true if the user's response is correct; otherwise, false.</returns>
		bool ValidateResponse(IPAddress ipAddress, string challenge, string response);
	}
}