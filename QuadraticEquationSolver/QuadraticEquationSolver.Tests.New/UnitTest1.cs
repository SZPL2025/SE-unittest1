using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationSolver.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(1, 0, -1, 1, -1)] // Two roots
        [InlineData(1, -2, 1, 1, null)] // One root
        [InlineData(1, 0, 1, null, null)] // No real roots
        public void SolveQuadratic_ReturnsExpectedResults(
            double a, double b, double c, double? expectedRoot1, double? expectedRoot2)
        {
            // Act
            var result = Solver.SolveQuadratic(a, b, c);

            // Assert
            Assert.Equal(expectedRoot1, result.Item1);
            Assert.Equal(expectedRoot2, result.Item2);
        }

        [Fact]
        public void SolveQuadratic_ThrowsException_WhenACoefficientIsZero()
        {
            // Arrange
            double a = 0, b = 2, c = 1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Solver.SolveQuadratic(a, b, c));
        }
    }
}
