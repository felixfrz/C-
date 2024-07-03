using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class11
    {
        static async void Test1()
        {
            Console.WriteLine("Started reading values from DB.....");
            await Task.Delay(10000);
            Console.WriteLine("Completed reading values from DB.....");
        }
        static void Test2()
        {
            Console.Write("Please enter your name: ");
            string? Name = Console.ReadLine();
            Console.WriteLine($"Name you entered is: {Name}");
        }

        static void Main(string[] args)
        {
            Test1();
            Test2();
            Console.ReadLine();
        }

    }
}
