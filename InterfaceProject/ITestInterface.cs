using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal interface ITestInterface
    {
        void Add(int a, int b);
    }

    interface ITestInterface2 : ITestInterface
    {
        void Sub(int a, int b);
    }

    class Implementation : ITestInterface2, Interface3
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }


        static void Main()
        {
            Implementation obj = new Implementation();
            int[] arr = { 1, 2, 3, 4, 5 };

            var res = from i in arr select i;

            foreach (int i in res)
                Console.WriteLine(i);
            

            obj.Add(1, 2);
            obj.Sub(35, 12);
            obj.Mul(3, 4);
            Interface3 obj1 = new Implementation();
            obj1.Div(10, 2);
            obj1.Mul(2, 3);
            Console.ReadLine();
        }
    }
}
