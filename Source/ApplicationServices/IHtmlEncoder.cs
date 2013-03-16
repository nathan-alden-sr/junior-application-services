namespace Junior.ApplicationServices
{
	public interface IHtmlEncoder
	{
		string Encode(string value, HtmlEncoderOptions options = HtmlEncoderOptions.None);
		string Decode(string value);
	}
}