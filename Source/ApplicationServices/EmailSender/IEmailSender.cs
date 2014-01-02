using System.Collections.Generic;
using System.Threading.Tasks;

namespace Junior.ApplicationServices.EmailSender
{
	public interface IEmailSender
	{
		Task SendAsync(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<EmailRecipient> recipients);
		Task SendAsync(string subject, string body, EmailBodyFormat bodyFormat, params EmailRecipient[] recipients);
		Task SendAsync(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<string> toEmailAddresses);
		Task SendAsync(string subject, string body, EmailBodyFormat bodyFormat, params string[] toEmailAddresses);
	}
}