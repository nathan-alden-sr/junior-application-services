using System;

namespace Junior.ApplicationServices
{
	/// <summary>
	/// Represents a way to build absolute URLs given a relative URL.
	/// </summary>
	public interface IAbsoluteUrlBuilder
	{
		/// <summary>
		/// Builds an absolute URL given a relative URL.
		/// </summary>
		/// <param name="relativeUrl">A relative URL.</param>
		/// <returns>An absolute URL.</returns>
		Uri Build(string relativeUrl);
	}
}