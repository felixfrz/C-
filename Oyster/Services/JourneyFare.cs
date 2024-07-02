using Oyster.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyster.Models

{
    public class JourneyFare
    {
        public const float BUS_FARE = 1.80f;
        public const float MAX_TUBE_FARE = 3.20f;
        public const float ZONE_ONE_FARE = 2.50f;
        public const float ANY_ZONE_OUTSIDE_ZONE_ONE_FARE = 2.00f;
        public const float ANY_TWO_ZONES_INC_ZONE_ONE_FARE = 3.00f;
        public const float ANY_TWO_ZONES_EXC_ZONE_ONE_FARE = 2.25f;
        public const float ANY_THREE_ZONES_FARE = 3.20f;

        public void Validate(Transport transport, OysterCard card)
        {
            if (transport == Transport.BUS)
                card.ValidateBalance(BUS_FARE);
            else if (transport == Transport.TUBE)
                card.ValidateBalance(MAX_TUBE_FARE);
        }

        public void ChargeMaxFare(Transport transport, OysterCard card)
        {
            if (transport == Transport.BUS)
                card.DeductFare(BUS_FARE);
            else if (transport == Transport.TUBE)
                card.DeductFare(MAX_TUBE_FARE);
        }

        
        
        private int CountZones(Journey journey)
        {
            var startZones = journey.GetStartPoint().GetZone().Split(',');
            var endZones = journey.GetEndPoint().GetZone().Split(',');

            int minZoneDifference = int.MaxValue;

            foreach (var startZone in startZones)
            {
                foreach (var endZone in endZones)
                {
                    int zoneDifference = Math.Abs(int.Parse(startZone) - int.Parse(endZone));
                    if (zoneDifference < minZoneDifference)
                        minZoneDifference = zoneDifference;
                }
            }

            return minZoneDifference;
        }

        private bool IsZoneTwoOnly(Journey journey)
        {
            return journey.GetEndPoint().GetZone().Contains("2") && journey.GetStartPoint().GetZone().Contains("2");
        }

        private bool IsThreeZones(int count)
        {
            return count == 2;
        }

        private bool IsTwoZones(int count)
        {
            return count == 1;
        }

        private bool IsSingleZone(int count)
        {
            return count == 0;
        }

        private bool HasZoneOne(Journey journey)
        {
            return journey.GetEndPoint().GetZone().Contains("1") || journey.GetStartPoint().GetZone().Contains("1");
        }
        
        
        /// <summary>
        /// This method adjusts the fare at the end of a journey based on the zones traveled.
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="journey"></param>
        /// <param name="card"></param>
        public void AdjustFare(Transport transport, Journey journey, OysterCard card)
        {
            if (transport == Transport.TUBE)
            {
                int zoneCount = CountZones(journey);
                if (IsSingleZone(zoneCount) && IsZoneTwoOnly(journey))
                    card.Refund(MAX_TUBE_FARE - ANY_ZONE_OUTSIDE_ZONE_ONE_FARE);
                else if (HasZoneOne(journey) && IsSingleZone(zoneCount))
                    card.Refund(MAX_TUBE_FARE - ZONE_ONE_FARE);
                else if (!HasZoneOne(journey) && IsSingleZone(zoneCount))
                    card.Refund(MAX_TUBE_FARE - ANY_ZONE_OUTSIDE_ZONE_ONE_FARE);
                else if (HasZoneOne(journey) && IsTwoZones(zoneCount))
                    card.Refund(MAX_TUBE_FARE - ANY_TWO_ZONES_INC_ZONE_ONE_FARE);
                else if (!HasZoneOne(journey) && IsTwoZones(zoneCount))
                    card.Refund(MAX_TUBE_FARE - ANY_TWO_ZONES_EXC_ZONE_ONE_FARE);
                else if (IsThreeZones(zoneCount))
                    card.Refund(MAX_TUBE_FARE - ANY_THREE_ZONES_FARE);
            }
            else if (transport == Transport.BUS)
            {
                card.Refund(0f);
            }
        }

        
    }
}
