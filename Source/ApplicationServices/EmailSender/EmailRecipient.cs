using Junior.Common;

namespace Junior.ApplicationServices.EmailSender
{
	public class EmailRecipient
	{
		private readonly string _emailAddress;
		private readonly EmailRecipientType _type;

		public EmailRecipient(string emailAddress, EmailRecipientType type)
		{
			emailAddress.ThrowIfNull("emailAddress");

			_emailAddress = emailAddress;
			_type = type;
		}

		public string EmailAddress
		{
			get
			{
				return _emailAddress;
			}
		}

		public EmailRecipientType Type
		{
			get
			{
				return _type;
			}
		}
	}
}