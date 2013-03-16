using System;

namespace Junior.ApplicationServices
{
	public interface IAbsoluteUrlBuilder
	{
		Uri Build(string relativeUrl);
	}
}