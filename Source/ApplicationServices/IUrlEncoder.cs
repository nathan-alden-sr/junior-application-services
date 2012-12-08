namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to encode and decode URLs.
	/// </summary>
	public interface IUrlEncoder
	{
		/// <summary>
		/// Encodes a URL.
		/// </summary>
		/// <param name="value">The value to encode.</param>
		/// <returns>The encoded URL.</returns>
		string Encode(string value);

		/// <summary>
		/// Decodes a URL.
		/// </summary>
		/// <param name="value">The value to decode.</param>
		/// <returns>The decoded URL.</returns>
		string Decode(string value);
	}
}