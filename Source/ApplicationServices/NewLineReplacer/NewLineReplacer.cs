using System.Text;

using Junior.Common;

namespace Junior.ApplicationServices.NewLineReplacer
{
	public class NewLineReplacer : INewLineReplacer
	{
		public string ReplaceWithBrTags(string value)
		{
			value.ThrowIfNull("value");

			var stringBuilder = new StringBuilder(value);

			ReplaceWithBrTags(stringBuilder);

			return stringBuilder.ToString();
		}

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