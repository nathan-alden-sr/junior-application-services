using System;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Options that control how HTML is encoded.
	/// </summary>
	public enum HtmlEncoderOptions
	{
		/// <summary>
		/// Only normal HTML encoding.
		/// </summary>
		None,
		/// <summary>
		/// Replace <see cref="Environment.NewLine"/> occurrences with BR tags in addition to normal HTML encoding.
		/// </summary>
		ReplaceNewLinesWithBrTags
	}
}