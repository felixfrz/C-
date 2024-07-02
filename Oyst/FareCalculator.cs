using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyst
{
    public static class FareCalculator
    {
        private static readonly decimal MaxFare = 3.20m;
        private static readonly decimal BusFare = 1.80m;

        public static decimal CalculateFare(Trip trip)
        {
            if (trip.IsBusJourney)
            {
                return BusFare;
            }

            // Additional logic for tube fare calculation
            if (trip.StartStation != null && trip.EndStation != null)
            {
                var startZones = trip.StartStation.Zones;
                var endZones = trip.EndStation.Zones;

                // Sample fare calculation based on zones
                if (startZones[0] == 1 && endZones[0] == 1)
                    return 2.50m;
                else if (startZones.Length == 2 && endZones.Length == 2)
                    return 3.00m;
                else if (startZones[0] == 3)
                    return 2.00m;

                // More rules can be added here
            }

            return MaxFare;
        }
    }

}
