

namespace OysterTravel
{


    namespace OysterCardSystem
    {
        public class Station
        {
            public string Name { get; set; }
            public int[] Zones { get; set; }

            public Station(string name, params int[] zones)
            {
                Name = name;
                Zones = zones;
            }
        }

        public class OysterCard
        {
            public decimal Balance { get; private set; }

            private Station _currentStation;
            private static readonly decimal MaxFare = 3.20m;

            public OysterCard(decimal initialBalance)
            {
                Balance = initialBalance;
            }

            public void LoadMoney(decimal amount)
            {
                Balance += amount;
            }

            public void SwipeIn(Station station)
            {
                if (Balance < MaxFare)
                    throw new InvalidOperationException("Insufficient balance for the maximum fare.");

                _currentStation = station;
                Balance -= MaxFare;
            }

            public void SwipeOut(Station station)
            {
                if (_currentStation == null)
                    throw new InvalidOperationException("Swipe in first before swiping out.");

                decimal actualFare = FareCalculator.CalculateFare(_currentStation, station);
                Balance += MaxFare - actualFare;
                _currentStation = null;
            }

            public void TakeBus()
            {
                const decimal BusFare = 1.80m;
                if (Balance < BusFare)
                    throw new InvalidOperationException("Insufficient balance for the bus fare.");

                Balance -= BusFare;
            }

            public decimal GetBalance()
            {
                return Balance;
            }
        }

        public static class FareCalculator
        {
            public static decimal CalculateFare(Station start, Station end)
            {
                int[] startZones = start.Zones;
                int[] endZones = end.Zones;

                bool inZone1 = Array.Exists(startZones, z => z == 1) || Array.Exists(endZones, z => z == 1);
                int zoneDifference = Math.Abs(startZones[0] - endZones[0]);

                if (startZones.Length > 1 || endZones.Length > 1)
                    zoneDifference = 1; // Simplified assumption for multi-zone stations like Earl's Court

                if (zoneDifference == 0)
                    return inZone1 ? 2.50m : 2.00m;
                else if (zoneDifference == 1)
                    return inZone1 ? 3.00m : 2.25m;
                else
                    return 3.20m;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Station holborn = new Station("Holborn", 1);
                Station earlsCourt = new Station("Earl’s Court", 1, 2);
                Station hammersmith = new Station("Hammersmith", 2);
                Station wimbledon = new Station("Wimbledon", 3);

                OysterCard card = new OysterCard(30.00m);

                try
                {
                    // Trip 1: Tube from Holborn to Earl’s Court
                    card.SwipeIn(holborn);
                    card.SwipeOut(earlsCourt);
                    Console.WriteLine("Balance after Holborn to Earl’s Court: £" + card.GetBalance());

                    // Trip 2: 328 bus from Earl’s Court to Chelsea
                    card.TakeBus();
                    Console.WriteLine("Balance after bus to Chelsea: £" + card.GetBalance());

                    // Trip 3: Tube from Earl’s Court to Hammersmith
                    card.SwipeIn(earlsCourt);
                    card.SwipeOut(hammersmith);
                    Console.WriteLine("Balance after Earl’s Court to Hammersmith: £" + card.GetBalance());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }


                Console.ReadLine();
            }
        }
    }

}
