using System;
using System.Collections.Generic;

namespace OysterCardSystem
{
    public class OysterCard
    {
        public decimal Balance { get; private set; }

        public OysterCard(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void AddBalance(decimal amount)
        {
            Balance += amount;
        }

        public bool CanAffordTrip(decimal fare)
        {
            return Balance >= fare;
        }

        public void DeductFare(decimal fare)
        {
            if (CanAffordTrip(fare))
            {
                Balance -= fare;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }

        public void RefundMaxFare(decimal maxFare, decimal actualFare)
        {
            Balance += maxFare - actualFare;
        }
    }

    public class Station
    {
        public string Name { get; }
        public List<int> Zones { get; }

        public Station(string name, List<int> zones)
        {
            Name = name;
            Zones = zones;
        }
    }

    public class Trip
    {
        public Station StartStation { get; }
        public Station EndStation { get; }
        public bool IsBusTrip { get; }

        public Trip(Station start, Station end, bool isBusTrip)
        {
            StartStation = start;
            EndStation = end;
            IsBusTrip = isBusTrip;
        }
    }

    public static class FareCalculator
    {
        private const decimal MaxFare = 3.20m;
        private const decimal BusFare = 1.80m;
        private static readonly Dictionary<string, Station> Stations = new Dictionary<string, Station>
        {
            { "Holborn", new Station("Holborn", new List<int> { 1 }) },
            { "Earl’s Court", new Station("Earl’s Court", new List<int> { 1, 2 }) },
            { "Wimbledon", new Station("Wimbledon", new List<int> { 3 }) },
            { "Hammersmith", new Station("Hammersmith", new List<int> { 2 }) }
        };

        public static decimal CalculateFare(Trip trip)
        {
            if (trip.IsBusTrip)
            {
                return BusFare;
            }

            var startZones = trip.StartStation.Zones;
            var endZones = trip.EndStation.Zones;

            if (startZones.Contains(1) && endZones.Contains(1))
            {
                return 2.50m;
            }
            if (startZones.Count == 1 && endZones.Count == 1 && !startZones.Contains(1) && !endZones.Contains(1))
            {
                return 2.00m;
            }
            if (startZones.Contains(1) || endZones.Contains(1))
            {
                return 3.00m;
            }
            if (startZones.Count > 1 || endZones.Count > 1)
            {
                return 2.25m;
            }
            return 3.20m; // Max fare for default case.
        }

        public static Station GetStationByName(string name)
        {
            if (Stations.ContainsKey(name))
            {
                return Stations[name];
            }
            throw new ArgumentException("Station not found.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var oysterCard = new OysterCard(30.00m);

            var trips = new List<Trip>
            {
                new Trip(FareCalculator.GetStationByName("Holborn"), FareCalculator.GetStationByName("Earl’s Court"), false),
               // new Trip(FareCalculator.GetStationByName("Earl’s Court"), FareCalculator.GetStationByName("Chelsea"), true), // Note: Chelsea is not in the data, assuming generic bus trip
                new Trip(FareCalculator.GetStationByName("Earl’s Court"), FareCalculator.GetStationByName("Hammersmith"), false)
            };

            foreach (var trip in trips)
            {
                var maxFare = 3.20m;
                oysterCard.DeductFare(maxFare); // Deduct max fare initially

                var actualFare = FareCalculator.CalculateFare(trip);
                oysterCard.RefundMaxFare(maxFare, actualFare); // Refund difference between max fare and actual fare
            }

            Console.WriteLine($"Remaining balance: £{oysterCard.Balance}");

            Console.ReadKey();
        }
    }
}
