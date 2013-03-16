using System.Threading.Tasks;

namespace Junior.ApplicationServices
{
	public interface IEmailSender
	{
		Task Send(string subject, string body, EmailBodyFormat bodyFormat, params string[] toAddresses);
	}
}