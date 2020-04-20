using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.utils;
using FluentAssertions;

namespace tests.domain.utils
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void Capitalize_ReturnsFirstLetterUppercaseAndRestLowercase()
        {
            "FOO".Capitalize().Should().Be("Foo");
        }
    }
}