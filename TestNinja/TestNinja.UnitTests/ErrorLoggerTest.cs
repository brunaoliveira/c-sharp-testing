using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTest
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_ShouldSetTheLastErrorProperty()
        {
            _errorLogger.Log("SOME ERROR");

            Assert.That(_errorLogger.LastError, Is.EqualTo("SOME ERROR"));
        }

        [Test]
        public void Log_ValidError_ShouldRaiseErrorLoggedEvent()
        {
            // subscribe to the event adding a new handler
            var eventId = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { eventId = args; };

            _errorLogger.Log("SOME ERROR");

            Assert.That(eventId, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ShouldThrowArgumentNullException(string error)
        {
            // vai lançar uma exception e quebrar o teste -> fazer delegate
            //_errorLogger.Log(error);

            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }
    }
}
