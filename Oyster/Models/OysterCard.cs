

using Oyster.Exceptions;

namespace Oyster.Models
{
    public class OysterCard
    {
        private float _balance;

        public OysterCard(float balance)
        {
            _balance = balance;
        }

        public OysterCard()
        {
            _balance = 0;
        }

        public float GetBalance()
        {
            return _balance;
        }

        //public void SetBalance(float balance)
        //{
        //    _balance = balance;
        //}

      
        public void AddMoney(float money)
        {
            _balance += money;
        }

        public void DeductFare(float fare)
        {
            ValidateBalance(fare);
            _balance -= fare;
        }
        
        public void ValidateBalance(float fare)
        {
            if (_balance < fare)
                throw new FareException("You do not have enough balance to make this journey!");
        }

        public void Refund(float amount)
        {
            _balance += amount;
        }
    }
}
