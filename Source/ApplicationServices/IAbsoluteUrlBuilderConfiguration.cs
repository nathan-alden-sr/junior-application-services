using System;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents configuration necessary to build absolute URLs.
	/// </summary>
	public interface IAbsoluteUrlBuilderConfiguration
	{
		/// <summary>
		/// A root URL.
		/// </summary>
		Uri RootUrl
		{
			get;
		}
	}
}