using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class3
    {
        static int GetLength()
        {
            string str = "";
            for (int i = 1; i <= 100000; i++)
            {
                str += i;
            }
            return str.Length;
        }
        static string ToUpper()
        {
            string str = "Hello World";
            return str.ToUpper();
        }
        static void Main()
        {
            //Task<int> t1 = new Task<int>(GetLength);
            //Task<string> t2 = new Task<string>(ToUpper);
            //t1.Start(); t2.Start();
            // OR
            Task<int> t1 = Task.Factory.StartNew(GetLength);
            Task<string> t2 = Task.Factory.StartNew(ToUpper);

            int Result1 = t1.Result;
            string Result2 = t2.Result;
            Console.WriteLine($"Value of Result1 is: {Result1}");
            Console.WriteLine($"Value of Result2 is: {Result2}");
        }

    }
}
