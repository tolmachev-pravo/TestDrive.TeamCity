using NUnit.Framework;
using TestDrive.TeamCity.Library;
using Shouldly;

namespace TestDrive.TeamCity.Tests
{
    [TestFixture]
    public class ExampleClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void What_Should_What()
        {
            // Arrange
            var type = typeof(ExampleClass);

            // Act: 
            var summary = type.GetSummary();

            // Assert: 
            summary.ShouldNotBeEmpty();
        }
    }
}