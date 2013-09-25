using System;

namespace Junior.ApplicationServices.AbsoluteUrlBuilder
{
	public interface IAbsoluteUrlBuilder
	{
		Uri Build(string relativeUrl);
	}
}