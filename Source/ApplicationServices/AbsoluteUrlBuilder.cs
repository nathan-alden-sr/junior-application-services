using System;

using Junior.Common;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Builds absolute URLs.
	/// </summary>
	public class AbsoluteUrlBuilder : IAbsoluteUrlBuilder
	{
		private readonly IAbsoluteUrlBuilderConfiguration _configuration;

		/// <summary>
		/// Initializes a new instance of the <see cref="AbsoluteUrlBuilder"/> class.
		/// </summary>
		/// <param name="configuration">Configuration necessary to build absolute URLs.</param>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="configuration"/> is null.</exception>
		public AbsoluteUrlBuilder(IAbsoluteUrlBuilderConfiguration configuration)
		{
			configuration.ThrowIfNull("configuration");

			_configuration = configuration;
		}

		/// <summary>
		/// Builds an absolute URL given a relative URL.
		/// </summary>
		/// <param name="relativeUrl">A relative URL.</param>
		/// <returns>An absolute URL.</returns>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="relativeUrl"/> is null.</exception>
		public Uri Build(string relativeUrl)
		{
			relativeUrl.ThrowIfNull("relativeUrl");

			return new Uri(_configuration.RootUrl, relativeUrl);
		}
	}
}