using System;

using NUnit.Framework;

using Rhino.Mocks;

namespace Junior.ApplicationServices.UnitTests.ApplicationServices
{
	public static class AbsoluteUrlBuilderTester
	{
		[TestFixture]
		public class When_building_absolute_url
		{
			[Test]
			public void Must_combine_root_url_and_relative_url()
			{
				var configuration = MockRepository.GenerateMock<IAbsoluteUrlBuilderConfiguration>();

				configuration.Stub(arg => arg.RootUrl).Return(new Uri("http://localhost"));

				var systemUnderTest = new AbsoluteUrlBuilder(configuration);

				Uri absoluteUrl = systemUnderTest.Build("relative/url?key=value");

				Assert.That(absoluteUrl.ToString(), Is.EqualTo("http://localhost/relative/url?key=value"));
			}
		}
	}
}