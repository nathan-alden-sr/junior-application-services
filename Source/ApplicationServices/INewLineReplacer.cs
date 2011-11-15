using System;
using System.Text;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to replace <see cref="Environment.NewLine"/> occurrences with BR tags.
	/// </summary>
	public interface INewLineReplacer
	{
		/// <summary>
		/// Replaces <see cref="Environment.NewLine"/>, carriage return and line feed occurrences with BR tags.
		/// </summary>
		/// <param name="value">The value whose <see cref="Environment.NewLine"/>, carriage return and line feed occurrences are to be replaced.</param>
		/// <returns><paramref name="value"/> with its <see cref="Environment.NewLine"/>, carriage return and line feed occurrences replaced.</returns>
		string ReplaceWithBrTags(string value);

		/// <summary>
		/// Replaces <see cref="Environment.NewLine"/>, carriage return and line feed occurrences with BR tags.
		/// </summary>
		/// <param name="stringBuilder">A <see cref="StringBuilder"/> whose <see cref="Environment.NewLine"/>, carriage return and line feed occurrences are to be replaced.</param>
		/// <returns><paramref name="stringBuilder"/> with its <see cref="Environment.NewLine"/>, carriage return and line feed occurrences replaced.</returns>
		StringBuilder ReplaceWithBrTags(StringBuilder stringBuilder);
	}
}