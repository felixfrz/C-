using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMeLater
{
    internal class InOutParameters
    {
        public void Factorial(ref uint a)
        {
            if (a == 0 || a == 1)
                a = 1;
            else
            {
                uint result = 1;

                for (uint i = 2; i <= a; i++)
                    result *= i;
                a = result;
            }
        }


        static void Main()
        {
            InOutParameters obj = new InOutParameters();

            uint x = 5;
            Console.WriteLine("Value of x before execution of the method: " + x);

            obj.Factorial(ref x);

            Console.WriteLine("Value of x after execution of the method: " + x);
            Console.ReadLine();

        }
    }
}
