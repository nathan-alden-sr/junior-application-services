namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to encode and decode HTML.
	/// </summary>
	public interface IHtmlEncoder
	{
		/// <summary>
		/// Encodes HTML.
		/// </summary>
		/// <param name="value">The value to encode.</param>
		/// <param name="options">Encoding options.</param>
		/// <returns>The encoded HTML.</returns>
		string Encode(string value, HtmlEncoderOptions options = HtmlEncoderOptions.None);

		/// <summary>
		/// Decodes HTML.
		/// </summary>
		/// <param name="value">The value to decode.</param>
		/// <returns>The decoded HTML.</returns>
		string Decode(string value);
	}
}