using System;

using Junior.Common;

namespace Junior.ApplicationServices.AbsoluteUrlBuilder
{
	public class AbsoluteUrlBuilder : IAbsoluteUrlBuilder
	{
		private readonly IAbsoluteUrlBuilderConfiguration _configuration;

		public AbsoluteUrlBuilder(IAbsoluteUrlBuilderConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		public Uri Build(string relativeUrl)
		{
			relativeUrl.ThrowIfNull("relativeUrl");

			return new Uri(_configuration.RootUrl, relativeUrl);
		}
	}
}