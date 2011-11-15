using System;
using System.Text;

using NUnit.Framework;

namespace Junior.ApplicationServices.UnitTests.ApplicationServices
{
	public static class NewLineReplacerTester
	{
		[TestFixture]
		public class When_replacing_newlines_in_string_with_br_tags
		{
			[Test]
			public void Must_replace_environment_newlines_carriage_returns_and_line_feeds()
			{
				var systemUnderTest = new NewLineReplacer();
				string value = String.Format("Test\rTest\nTest{0}Test", Environment.NewLine);
				string actual = systemUnderTest.ReplaceWithBrTags(value);

				Assert.That(actual, Is.EqualTo("Test<br/>Test<br/>Test<br/>Test"));
			}
		}

		[TestFixture]
		public class When_replacing_newlines_in_stringbuilder_with_br_tags
		{
			[Test]
			public void Must_replace_environment_newlines_carriage_returns_and_line_feeds()
			{
				var systemUnderTest = new NewLineReplacer();
				var value = new StringBuilder(String.Format("Test\rTest\nTest{0}Test", Environment.NewLine));
				StringBuilder actual = systemUnderTest.ReplaceWithBrTags(value);

				Assert.That(actual.ToString(), Is.EqualTo("Test<br/>Test<br/>Test<br/>Test"));
			}
		}
	}
}