namespace Junior.ApplicationServices
{
	public interface IUrlEncoder
	{
		string Encode(string value);
		string Decode(string value);
	}
}