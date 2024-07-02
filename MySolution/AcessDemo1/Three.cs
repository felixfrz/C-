using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessDemo1
{
    internal class Three
    {
        static void Main()
        {

            Program p = new Program();

            p.Test2_Internal();
            p.Test4_ProtecedInternal();
            p.Test5_Public();

            Console.ReadLine();
        }
    }
}
