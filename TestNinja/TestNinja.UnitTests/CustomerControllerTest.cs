using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTest
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ShouldReturnNotFound()
        {
            // Act
            var result = _customerController.GetCustomer(0);

            // Assert
            Assert.That(result, Is.TypeOf<NotFound>()); // resultado é exatamente do tipo NotFound
            Assert.That(result, Is.InstanceOf<NotFound>()); // resultado do tipo NotFound ou um dos seus derivados
        }
    }
}
