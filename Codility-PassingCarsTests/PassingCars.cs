using Codility_PassingCars;

namespace Codility_PassingCarsTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_ReturnsCorrectPassingPairs()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 0, 1, 0, 1, 1 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Solution_ReturnsZeroPassingPairs()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 1, 1, 1, 1, 1 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Solution_ReturnsNegativeOneForExceedingThreshold()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(105, result);
        }

        [Fact]
        public void Solution_ReturnsNegativeTwoForInvalidInputLength()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[100001]; // Input length exceeds RANGE_HIGHEST_VALUE

            // Act
            int result = solution.solution(input);

            // Assert
            Assert.Equal(-2, result);
        }
    }
}