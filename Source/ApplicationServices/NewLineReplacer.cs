using System;
using System.Text;

using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Replaces <see cref="Environment.NewLine"/> occurrences with BR tags.
	/// </summary>
	public class NewLineReplacer : INewLineReplacer
	{
		/// <summary>
		/// Replaces <see cref="Environment.NewLine"/>, carriage return and line feed occurrences with BR tags.
		/// </summary>
		/// <param name="value">The value whose <see cref="Environment.NewLine"/>, carriage return and line feed occurrences are to be replaced.</param>
		/// <returns><paramref name="value"/> with its <see cref="Environment.NewLine"/>, carriage return and line feed occurrences replaced.</returns>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
		public string ReplaceWithBrTags(string value)
		{
			value.ThrowIfNull("value");

			var stringBuilder = new StringBuilder(value);

			ReplaceWithBrTags(stringBuilder);

			return stringBuilder.ToString();
		}

		/// <summary>
		/// Replaces <see cref="Environment.NewLine"/>, carriage return and line feed occurrences with BR tags.
		/// </summary>
		/// <param name="stringBuilder">A <see cref="StringBuilder"/> whose <see cref="Environment.NewLine"/>, carriage return and line feed occurrences are to be replaced.</param>
		/// <returns><paramref name="stringBuilder"/> with its <see cref="Environment.NewLine"/>, carriage return and line feed occurrences replaced.</returns>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="stringBuilder"/> is null.</exception>
		public StringBuilder ReplaceWithBrTags(StringBuilder stringBuilder)
		{
			stringBuilder.ThrowIfNull("stringBuilder");

			stringBuilder.Replace("\r\n", "<br/>");
			stringBuilder.Replace("\r", "<br/>");
			stringBuilder.Replace("\n", "<br/>");

			return stringBuilder;
		}
	}
}