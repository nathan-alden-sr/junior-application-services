using System;

namespace Junior.ApplicationServices.AbsoluteUrlBuilder
{
	public interface IAbsoluteUrlBuilderConfiguration
	{
		Uri RootUrl
		{
			get;
		}
	}
}