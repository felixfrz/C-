using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMeLater
{
    public delegate string GreetDel(string name);
    public delegate void Greet2Del();
    internal class LambaExpression
    {


        //public static string Greet1(string name)
        //{
        //    return $"Hi {name}, hope you are good!!!";
        //}

        //public void Greet2()
        //{
        //    Console.WriteLine("Hello Admin");
        //}


        static void Main(string[] args)
        {
            LambaExpression lb = new LambaExpression();

            GreetDel greetDel = (string name) =>
            {
                return $"Hi {name}, hope you are good!!!";
            };

            string str = greetDel.Invoke("Deji");
            Console.WriteLine(str);

            Greet2Del greet2Del = () => Console.WriteLine("Hello Admin");

            greet2Del();

            Console.ReadLine();

        }
    }
}
