using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyst
{
    public class Trip
    {
        public Station StartStation { get; }
        public Station EndStation { get; private set; }
        public bool IsBusJourney { get; }

        public Trip(Station startStation, bool isBusJourney = false)
        {
            StartStation = startStation;
            IsBusJourney = isBusJourney;
        }

        public void EndTrip(Station endStation)
        {
            EndStation = endStation;
        }
    }

}
