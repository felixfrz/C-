using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    internal class Class1:Program
    {



        static int x;

        const int  y = 123;

        int z = 3;

        public new void TT(string name)
        {
            Console.WriteLine("helllllloo "+ name);
        }

        public static void Main()
        {

       
            Console.WriteLine("Hello");

            Class1 class1 = new Class1();

            class1.TT("Felix");

            Console.ReadLine();
        }
    }
}
