using System;

namespace Junior.ApplicationServices
{
	public interface IAbsoluteUrlBuilderConfiguration
	{
		Uri RootUrl
		{
			get;
		}
	}
}