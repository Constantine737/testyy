using Xunit;

namespace QuadraticEquation.Tests
{
    public class QuadraticEquationTests
    {
        [Theory]
        [InlineData(1, -3, 2, 1, 2)] // Two real roots
        [InlineData(1, 2, 1, -1)] // One real root
        [InlineData(1, 1, 1)] // No real roots
        public void CalculateRoots_ShouldReturnCorrectResult(double a, double b, double c, params double[] expectedRoots)
        {
            // Arrange
            var quadraticEquation = new Program();

            // Act
            var actualRoots = quadraticEquation.CalculateRoots(a, b, c);

            // Assert
            Assert.Equal(expectedRoots.Length, actualRoots.Length);
            for (int i = 0; i < expectedRoots.Length; i++)
            {
                Assert.Equal(expectedRoots[i], actualRoots[i], precision: 5);
            }
        }
    }
}
