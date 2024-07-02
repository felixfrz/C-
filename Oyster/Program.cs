using Oyster.Constants;
using Oyster.Enums;
using Oyster.Models;

namespace Oyster
{

    class Program
    {
        public static void Main(string[] args)
        {
            // Load the card with £30
            OysterCard card = new OysterCard(30);
            JourneyFare fare = new JourneyFare();
            
            // Journey 1: Tube from Holborn to Earl's Court
            Journey journey1 = new Journey(fare);
            journey1.SetStartPoint(Transport.TUBE, new Zone(Station.HOLBORN), card);
            journey1.SetEndPoint(new Zone(Station.EARLS_COURT));
            Console.WriteLine($"Balance after Holborn to Earl's Court: £{card.GetBalance()}");

            // Journey 2: 328 bus from Earl's Court to Chelsea
            Journey journey2 = new Journey(fare);
            journey2.SetStartPoint(Transport.BUS, new Zone(Station.EARLS_COURT), card);
            journey2.SetEndPoint(new Zone(Station.EARLS_COURT)); // Same zone for bus journey
            Console.WriteLine($"Balance after 328 bus from Earl's Court to Chelsea: £{card.GetBalance()}");

            // Journey 3: Tube from Earl's Court to Hammersmith
            Journey journey3 = new Journey(fare);
            journey3.SetStartPoint(Transport.TUBE, new Zone(Station.EARLS_COURT), card);
            journey3.SetEndPoint(new Zone(Station.HAMMERSMITH));
            Console.WriteLine($"Balance after Earl's Court to Hammersmith: £{card.GetBalance()}");

            //card.AddMoney(10);

           // card.DeductFare(5);
            
           // card.Refund(5);

           // Console.WriteLine(card.GetBalance());
            
            Console.ReadLine();
        }
    }
}
