using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeleteMeLater
{
    internal class GenericDelegate
    {
        //public static double AddNum(int a, float b, double c)
        //{
        //    return a + b + c;
        //}


        //public void Greet(string name)
        //{
        //    Console.WriteLine($"Hello {name}");
        //}
       

        static void Main(string[] args)
        {
            Func<int, float, double, double> obj = (int a, float b, double c) => a + b + c;

            double dou = obj(1, 2f, 3);

            Console.WriteLine(dou);

            Action<string> ac = (name) => Console.WriteLine($"Hello {name}");
            

            ac("Felixfrz");



            

            
            Console.ReadLine();

        }
    }
}
