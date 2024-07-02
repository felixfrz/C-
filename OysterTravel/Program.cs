

namespace OysterTravel
{
    public class OysterCard
    {
        public decimal Balance { get; private set; }

        public OysterCard(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void LoadMoney(decimal amount)
        {
            Balance += amount;
        }

        public bool DeductFare(decimal fare)
        {
            if (Balance >= fare)
            {
                Balance -= fare;
                return true;
            }
            return false;
        }

        public void RefundFare(decimal fare)
        {
            Balance += fare;
        }
    }

    public class Station
    {
        public string Name { get; private set; }
        public List<int> Zones { get; private set; }

        public Station(string name, List<int> zones)
        {
            Name = name;
            Zones = zones;
        }
    }

    public static class FareCalculator
    {
        public static decimal CalculateFare(Station entry, Station exit)
        {
            if (entry == null || exit == null)
            {
                return 3.20m; // Maximum fare for incomplete journey
            }

            if (entry.Zones.Contains(1) && exit.Zones.Contains(1))
            {
                return 2.50m; // Zone 1 travel
            }

            var commonZones = new HashSet<int>(entry.Zones);
            commonZones.IntersectWith(exit.Zones);

            if (commonZones.Count > 0)
            {
                if (entry.Zones.Contains(1) || exit.Zones.Contains(1))
                {
                    return 3.00m; // Two zones including zone 1
                }
                return 2.25m; // Two zones excluding zone 1
            }

            return 3.20m; // Default to maximum fare
        }
    }

    public class Trip
    {
        private Station _entryStation;
        private readonly OysterCard _oysterCard;
        private readonly Dictionary<string, Station> _stations;
        private const decimal BusFare = 1.80m;
        private const decimal MaxFare = 3.20m;

        public Trip(OysterCard oysterCard, Dictionary<string, Station> stations)
        {
            _oysterCard = oysterCard;
            _stations = stations;
        }

        public void StartTrip(string stationName)
        {
            if (_stations.ContainsKey(stationName))
            {
                _entryStation = _stations[stationName];
                _oysterCard.DeductFare(MaxFare); // Deduct maximum fare on entry
            }
            else
            {
                throw new ArgumentException("Station not found");
            }
        }

        public void EndTrip(string stationName)
        {
            if (_stations.ContainsKey(stationName))
            {
                var exitStation = _stations[stationName];
                var actualFare = FareCalculator.CalculateFare(_entryStation, exitStation);
                _oysterCard.RefundFare(MaxFare); // Refund maximum fare
                _oysterCard.DeductFare(actualFare); // Deduct actual fare
            }
            else
            {
                throw new ArgumentException("Station not found");
            }
        }

        public void BusTrip()
        {
            _oysterCard.DeductFare(BusFare); // Deduct bus fare
        }
    }

    public class Program
    {
        public static void Main()
        {
            var stations = new Dictionary<string, Station>
        {
            { "Holborn", new Station("Holborn", new List<int> { 1 }) },
            { "Earl's Court", new Station("Earl's Court", new List<int> { 1, 2 }) },
            { "Wimbledon", new Station("Wimbledon", new List<int> { 3 }) },
            { "Hammersmith", new Station("Hammersmith", new List<int> { 2 }) }
        };

            var oysterCard = new OysterCard(30.00m);
            var trip = new Trip(oysterCard, stations);

            Console.WriteLine($"Initial Balance: £{oysterCard.Balance}");

            trip.StartTrip("Holborn");
            trip.EndTrip("Earl's Court");
            Console.WriteLine($"Balance after Holborn to Earl's Court: £{oysterCard.Balance}");

            trip.BusTrip();
            Console.WriteLine($"Balance after bus from Earl's Court to Chelsea: £{oysterCard.Balance}");

            trip.StartTrip("Earl's Court");
            trip.EndTrip("Hammersmith");
            Console.WriteLine($"Balance after Earl's Court to Hammersmith: £{oysterCard.Balance}");


            Console.ReadLine();
        }
    }

}
