using ConsoleApp2;
using System.Linq;
using Xunit;

namespace ConsoleApp2.Tests
{
    public class CardTests
    {
        [Fact]
        public void GetDescription_ShouldReturnCorrectDescription()
        {
            // Arrange
            var card = new Card { Value = 5, Suit = 1 };

            // Act
            var description = card.GetDescription();

            // Assert
            Assert.Equal("Value: 5, Suit: 1", description);
        }

        [Fact]
        public void CardProperties_ShouldSetAndGetCorrectly()
        {
            // Arrange
            var card = new Card();

            // Act
            card.Value = 10;
            card.Suit = 3;

            // Assert
            Assert.Equal(10, card.Value);
            Assert.Equal(3, card.Suit);
        }
    }
}
