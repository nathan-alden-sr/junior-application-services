using System.Text;

namespace Junior.ApplicationServices
{
	public interface INewLineReplacer
	{
		string ReplaceWithBrTags(string value);
		StringBuilder ReplaceWithBrTags(StringBuilder stringBuilder);
	}
}