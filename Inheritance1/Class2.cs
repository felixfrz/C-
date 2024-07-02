using System;
using static System.Net.WebRequestMethods;
using System.IO;
using System.Numerics;


namespace Inheritance1
{
    internal class Class2 : Class1
    {
        public Class2(int c, int d) : base(c)
        {
            Console.WriteLine("Class2 constructor is called: " + d);
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }



        static void Main(string[] args)
        {

            Class2 c = new Class2(20, 30);



            c.Test1();


            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
