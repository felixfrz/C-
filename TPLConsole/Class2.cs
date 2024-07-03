using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLConsole
{
    internal class Class2
    {
        static void Print1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");
            }
        }
        static void Print2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
                if(i == 50)
                    Thread.Sleep(10000);
            }
        }
        static void Print3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
            }
        }
        static void Main(string[] args)
        {
            //Task t1 = new Task(Print1);
            //Task t2 = new Task(Print2);
            //Task t3 = new Task(Print3);
            //t1.Start(); t2.Start(); t3.Start();
            //t1.Wait(); t2.Wait(); t3.Wait();
            //Console.WriteLine($"Main thread with Id: {Thread.CurrentThread.ManagedThreadId} is exiting.");
            // OR
            Task t1 = Task.Factory.StartNew(Print1);
            Task t2 = Task.Factory.StartNew(Print2);
            Task t3 = Task.Factory.StartNew(Print3);
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine($"Main thread with Id: {Thread.CurrentThread.ManagedThreadId} is exiting.");


        }

    }
}
