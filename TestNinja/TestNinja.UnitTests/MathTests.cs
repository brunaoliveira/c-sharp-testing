using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because testing ignore tag ")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        // PARAMTHERIZED TEST
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(3, 3, 3)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            //Act
            var result = _math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnSecondArgument()
        {
            //Act
            var result = _math.Max(2, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetOddNumbers_()
        {

            //Act


            //Assert

        }

    }
}
