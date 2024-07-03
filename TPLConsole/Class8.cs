using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
           

            string str1 = "";
            sw1.Start();
            for (int i = 1; i < 100000; i++)
            {
                str1 += i;
            }
            sw1.Stop();



            Stopwatch sw2 = new Stopwatch();
            string str2 = "";
            sw2.Start();
            Parallel.For(1, 100000, (i) =>
            {
                str2 += i;
            });
            sw2.Stop();


            Console.WriteLine("Time taken to execute the code by using sequential for loop: " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to execute the code by using parallel for loop: " + sw2.ElapsedMilliseconds);

          Console.ReadLine();

        }
    }
}
