using FluentAssertions;
using Oyster.Constants;
using Oyster.Enums;
using Oyster.Exceptions;
using Oyster.Models;
using Xunit;
namespace RealOysterProjectTest
{
  
        
        public class CardTests
        {
            [Fact]
            public void AddMoney_ShouldIncreaseBalance()
            {
                // Arrange
                var card = new OysterCard(10);

                // Act
                card.AddMoney(20);

                // Assert
                card.GetBalance().Should().Be(30);
            }

            [Fact]
            public void DeductFare_ShouldDecreaseBalance()
            {
                // Arrange
                var card = new OysterCard(10);

                // Act
                card.DeductFare(5);

                // Assert
                card.GetBalance().Should().Be(5);
            }

            [Fact]
            public void DeductFare_ShouldThrowException_WhenInsufficientBalance()
            {
                // Arrange
                var card = new OysterCard(10);

                // Act
                Action act = () => card.DeductFare(15);

                // Assert
                act.Should().Throw<FareException>().WithMessage("You do not have enough balance to make this journey!");
            }

            [Fact]
            public void Refund_ShouldIncreaseBalance()
            {
                // Arrange
                var card = new OysterCard(10);

                // Act
                card.Refund(5);

                // Assert
                card.GetBalance().Should().Be(15);
            }






            [Fact]
            public void SetStartPoint_ShouldChargeMaxFare()
            {
                // Arrange
                var card = new OysterCard(10);
                var fare = new JourneyFare();
                var journey = new Journey(fare);

                // Act
                journey.SetStartPoint(Transport.TUBE, new Zone(Station.HOLBORN), card);

                // Assert
                card.GetBalance().Should().Be(10 - JourneyFare.MAX_TUBE_FARE);
            }

            [Fact]
            public void SetEndPoint_ShouldAdjustFare()
            {
                // Arrange
                var card = new OysterCard(10);
                var fare = new JourneyFare();
                var journey = new Journey(fare);

                // Act
                journey.SetStartPoint(Transport.TUBE, new Zone(Station.HOLBORN), card);
                journey.SetEndPoint(new Zone(Station.EARLS_COURT));

                // Assert
                card.GetBalance().Should().Be(10 - JourneyFare.ZONE_ONE_FARE);
            }

        [Fact]
        public void Validate_ShouldNotThrow_WhenSufficientBalanceForBus()
        {
            // Arrange
            var card = new OysterCard(2);
            var fare = new JourneyFare();

            // Act
            Action act = () => fare.Validate(Transport.BUS, card);

            // Assert
            act.Should().NotThrow();
        }

        [Fact]
        public void Validate_ShouldThrow_WhenInsufficientBalanceForBus()
        {
            // Arrange
            var card = new OysterCard(1);
            var fare = new JourneyFare();

            // Act
            Action act = () => fare.Validate(Transport.BUS, card);

            // Assert
            act.Should().Throw<FareException>().WithMessage("You do not have enough balance to make this journey!");
        }

        [Fact]
        public void ChargeMaxFare_ShouldDeductMaxFareForTube()
        {
            // Arrange
            var card = new OysterCard(10);
            var fare = new JourneyFare();

            // Act
            fare.ChargeMaxFare(Transport.TUBE, card);

            // Assert
            card.GetBalance().Should().Be(10 - JourneyFare.MAX_TUBE_FARE);
        }

        [Fact]
        public void AdjustFare_ShouldRefundDifferenceForZoneOne()
        {
            // Arrange
            var card = new OysterCard(10);
            var fare = new JourneyFare();
            var journey = new Journey(fare);

            // Act
            journey.SetStartPoint(Transport.TUBE, new Zone(Station.HOLBORN), card);
            journey.SetEndPoint(new Zone(Station.EARLS_COURT));

            // Assert
            card.GetBalance().Should().Be(10 - JourneyFare.ZONE_ONE_FARE);
        }

    }
 
}