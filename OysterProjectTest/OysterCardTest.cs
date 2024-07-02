
using FluentAssertions;
using Oyster.Exceptions;
using Oyster.Models;

namespace OysterProjectTest
{
    public class OysterCardTest
    {

        [Fact]
        public void TestValidateException()
        {
            // Arrange
            OysterCard card = new OysterCard(30f);

            // Act
            Action act = () => card.ValidateBalance(40);

            // Assert
            act.Should().Throw<FareException>().WithMessage("You don't have enough balance!");
        }

        [Fact]
        public void TestOutException()
        {
            // Arrange
            OysterCard card = new OysterCard(30f);

            // Act
            Action act = () => card.DeductFare(40);

            // Assert
            act.Should().Throw<FareException>().WithMessage("You don't have enough balance!");
        }
    }
}
