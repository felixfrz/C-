using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class7
    {
        public static void Print()
        {
           lock (typeof(Class7))
            {
                Console.Write("[CSharp Is ");
               // Task.Delay(5000).Wait();
                Console.WriteLine("Object Oriented]");
            }
        }
        static void Main()
        {
            Task t1 = new Task(Print);
            Task t2 = new Task(Print);
            Task t3 = new Task(Print);
            t1.Start(); t2.Start(); t3.Start();
            t1.Wait(); t2.Wait(); t3.Wait();
          //  Or
            //    Task t1 = Task.Factory.StartNew(Print);
            //Task t2 = Task.Factory.StartNew(Print);
            //Task t3 = Task.Factory.StartNew(Print);
            //Task.WaitAll(t1, t2, t3);
        }

    }
}
