using NUnit.Framework;
using CopilotInstructionsTest;

namespace SampleUnitTest
{
    /// <summary>
    /// Contains unit tests for the <see cref="AdditionHelper"/> class.
    /// </summary>
    [TestFixture]
    public class AdditionHelperTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int result = AdditionHelper.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -4;
            int b = -6;

            // Act
            int result = AdditionHelper.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -3;

            // Act
            int result = AdditionHelper.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            // Arrange
            int a = 42;
            int b = 0;

            // Act
            int result = AdditionHelper.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void Add_BothZero_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int result = AdditionHelper.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
