using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldWrapStringInStrongElement()
        {
            // Arrange 
            var formatter = new HtmlFormatter();

            // Act
            var result = formatter.FormatAsBold("SOME STRING");

            // Specific asserttion (Not adequate if method can return error message, once it can be modified in the future)
            Assert.That(result, Is.EqualTo("<strong>SOME STRING</strong>"));

            // General assertion (Not adequate because it can pass even if the original method has issues)
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("SOME STRING"));
        }
    }
}
