using ConsoleApp2;
using Xunit;


namespace ConsoleApp2.Tests
{
    public class MathsTutorTests
    {
        [Theory]
        [InlineData(1, '+')]
        [InlineData(2, '-')]
        [InlineData(3, '*')]
        [InlineData(4, '/')]
        public void GetOperatorFromSuit_ShouldReturnCorrectOperator(int suit, char expectedOperator)
        {
            // Arrange
            var mathsTutor = new Program();

            // Act
            char result = Program.GetOperatorFromSuit(1);

            // Assert
            Assert.Equal('+', result);
        }
    }
}