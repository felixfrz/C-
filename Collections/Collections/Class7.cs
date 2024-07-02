using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Class7
    {
        static void Main()
        {
            //Copying values > 40 from 1 array to another array and arranging them in descending order
            int[] arr = { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };

            int Count = 0, Index = 0;
            foreach (int i in arr)
            {
                if (i > 40)
                {
                    Count += 1;
                }
            }
            int[] brr = new int[Count];
            foreach (int i in arr)
            {
                if (i > 40)
                {
                    brr[Index] = i;
                    Index += 1;
                }
            }

            Array.Sort(brr);
            Array.Reverse(brr);
            Console.WriteLine(String.Join(", ", brr));
            Console.ReadLine();
        }

    }
}
