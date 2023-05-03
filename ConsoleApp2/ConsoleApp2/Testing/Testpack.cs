using ConsoleApp2;
using System.Linq;
using Xunit;


namespace ConsoleApp2.Tests
{
    public class PackTests
    {
        [Fact]
        public void PackConstructor_ShouldCreateFullPack()
        {
            // Act
            var pack = new Pack();

            // Assert
            Assert.Equal(52, pack.CardCount);
        }

        [Fact]
        public void PackConstructor_ShouldCreateUniqueCards()
        {
            // Act
            var pack = new Pack();

            // Assert
            var uniqueCards = pack.Cards.Distinct().Count();
            Assert.Equal(52, uniqueCards);
        }

        [Fact]
        public void DrawCard_ShouldRemoveCardFromPack()
        {
            // Arrange
            var pack = new Pack();
            int initialCount = pack.CardCount;

            // Act
            var drawnCard = pack.DrawCard();

            // Assert
            Assert.Equal(initialCount - 1, pack.CardCount);
            Assert.DoesNotContain(drawnCard, pack.Cards);
        }
    }
}
