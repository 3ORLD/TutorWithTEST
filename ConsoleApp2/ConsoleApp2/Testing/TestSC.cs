using ConsoleApp2;
using Jesses_Tutor.Main;
using Xunit;


namespace ConsoleApp2.Tests
{
    public class SpecialCardTests
    {
        [Fact]
        public void GetDescription_ShouldReturnSpecialCardDescription()
        {
            // Arrange
            var specialCard = new SpecialCard
            {
                Value = 10,
                Suit = 2
            };

            // Act
            string result = specialCard.GetDescription();

            // Assert
            Assert.Equal("SPECIAL CARD - Value: 10, Suit: 2", result);
        }
    }
}