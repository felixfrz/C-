using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMeLater
{
    internal class OutputParameters
    {

        public void Math1(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }

        public (int, int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }

        public void Math3(int a, int b, out int c)
        {
            c = a + b;
        }
        static void Main()
        {
            OutputParameters obj = new OutputParameters();


            int sum1, product1;
            obj.Math1(100, 25, out sum1, out product1);
            Console.WriteLine($"Output Parameter: Sum - {sum1} and Product - {product1} \n");


            var (a, b) = obj.Math2(2, 6);
            Console.WriteLine($"A " + a + "\n");

            Console.WriteLine($"B " + b + "\n");




            int ans;
            obj.Math3(2, 3, out ans);


            Console.WriteLine($"Output Parameter {ans}");

            Console.ReadLine();
        }
    }
}
