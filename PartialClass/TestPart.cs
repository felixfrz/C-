using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class TestPart
    {
        static void Main()
        {
            Parts p = new Parts();

            p.Method1();
            p.Method2();
            p.Method3();
            p.Method4();


            Console.ReadLine();
        }
    }
}
