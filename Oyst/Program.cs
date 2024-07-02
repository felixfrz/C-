namespace Oyst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize stations
            var holborn = new Station("Holborn", 1);
            var earlsCourt = new Station("Earl’s Court", 1, 2);
            var chelsea = new Station("Chelsea");
            var hammersmith = new Station("Hammersmith", 2);

            // Initialize card
            var oysterCard = new OysterCard(30m);

            // Trips
            var trip1 = new Trip(holborn);
            oysterCard.DeductFare(FareCalculator.CalculateFare(trip1)); // Deduct max fare
            trip1.EndTrip(earlsCourt);
            oysterCard.RefundFare(FareCalculator.CalculateFare(trip1)); // Refund difference

            var trip2 = new Trip(earlsCourt, true); // Bus journey
            oysterCard.DeductFare(FareCalculator.CalculateFare(trip2));

            var trip3 = new Trip(earlsCourt);
            oysterCard.DeductFare(FareCalculator.CalculateFare(trip3)); // Deduct max fare
            trip3.EndTrip(hammersmith);
            oysterCard.RefundFare(FareCalculator.CalculateFare(trip3)); // Refund difference

            // Output balance
            Console.WriteLine($"Balance after trips: £{oysterCard.Balance}");

            Console.ReadKey();
        }
    }

}
