
using Oyster.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oyster.Enums;

namespace Oyster.Models
{
    public class Journey
    {
        private Zone _startPoint;
        private Zone _endPoint;
        private Transport _transport;
        private OysterCard _card;
        private JourneyFare _fare;

        public Journey(JourneyFare fare)
        {
            _fare = fare;
        }

        public void SetStartPoint(Transport transport, Zone startPoint, OysterCard card)
        {
            //try
            //{
                _fare.Validate(transport, card);
                _fare.ChargeMaxFare(transport, card);
           // }
           // catch (Exception ex)
            //{
              //  throw ex.Message;
           // }

            _transport = transport;
            _card = card;
            _startPoint = startPoint;
        }

        public void SetEndPoint(Zone endPoint)
        {
            _endPoint = endPoint;
            _fare.AdjustFare(_transport, this, _card);
        }

        public Zone GetStartPoint()
        {
            return _startPoint;
        }

        public Zone GetEndPoint()
        {
            return _endPoint;
        }
    }
}
