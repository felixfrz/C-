using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class5
    {
        static void GetLength(int ub)
        {
            string str = "";
            for (int i = 1; i <= ub; i++)
            {
                str += i;
            }
            Console.WriteLine(str.Length);
        }
        static void ToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        
        static void Main()
        {
            Task t1 = new Task(() => GetLength(5000000));
            Task t2 = new Task(() => ToUpper("hello frz"));

            t1.Start(); t2.Start();

            t1.Wait(); t2.Wait();
        }
    }
}
