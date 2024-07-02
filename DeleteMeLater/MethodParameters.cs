using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMeLater
{
    internal class MethodParameters
    {
        int x = 100; 
        static int y = 200;
         const int t = 66;
        readonly bool flag;
        public MethodParameters()
        {
            flag = true;
        }
        static void Main()
        {
            MethodParameters p = new MethodParameters();
 
            Console.WriteLine(p.x);
          
            Console.WriteLine(t);


            Console.ReadLine(); 
        }
    }
}
