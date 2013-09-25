using System.Text;

namespace Junior.ApplicationServices.NewLineReplacer
{
	public interface INewLineReplacer
	{
		string ReplaceWithBrTags(string value);
		StringBuilder ReplaceWithBrTags(StringBuilder stringBuilder);
	}
}