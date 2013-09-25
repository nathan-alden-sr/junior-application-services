using System.Collections.Generic;
using System.Threading.Tasks;

namespace Junior.ApplicationServices.EmailSender
{
	public interface IEmailSender
	{
		Task Send(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<EmailRecipient> recipients);
		Task Send(string subject, string body, EmailBodyFormat bodyFormat, params EmailRecipient[] recipients);
		Task Send(string subject, string body, EmailBodyFormat bodyFormat, IEnumerable<string> toEmailAddresses);
		Task Send(string subject, string body, EmailBodyFormat bodyFormat, params string[] toEmailAddresses);
	}
}