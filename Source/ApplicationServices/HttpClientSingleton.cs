using System.Net.Http;

namespace Junior.ApplicationServices
{
	public static class HttpClientSingleton
	{
		public static readonly HttpClient Instance = new HttpClient();
	}
}