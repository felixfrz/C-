using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class AbsChild : AbsParent
    {

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }



        static void Main()
        {
            AbsChild c = new AbsChild();
            
            c.Add(150, 45);
            c.Sub(78, 23);
            c.Mul(122, 34);
            c.Div(789, 34);


            Console.ReadLine();
        }
    }
}
