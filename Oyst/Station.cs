using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyst
{
    public class Station
    {
        public string Name { get; }
        public int[] Zones { get; }

        public Station(string name, params int[] zones)
        {
            Name = name;
            Zones = zones;
        }
    }

}
