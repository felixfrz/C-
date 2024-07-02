using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyst
{
    public class OysterCard
    {
        public decimal Balance { get; private set; }

        public OysterCard(decimal initialBalance)
        {
            Balance = initialBalance;
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

        public void LoadMoney(decimal amount)
        {
            Balance += amount;
        }

        public void RefundFare(decimal fare)
        {
            Balance += fare;
        }
    }

}

