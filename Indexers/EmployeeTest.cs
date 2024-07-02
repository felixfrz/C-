using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class EmployeeTest
    {




        static void Main()
        {
            Employee e = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");
            Console.WriteLine("Eno; " + e[0]);
            Console.WriteLine("Salary: " + e[1]);
            Console.WriteLine("Ename:" + e[2]);
            Console.WriteLine("Job:" + e[3]);
            Console.WriteLine("Dname:" + e[4]);
            Console.WriteLine("Location: " + e[5]);

            e[1] = 25000.00;
            e[3] = "Developer";

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Eno; " + e[0]);
            Console.WriteLine("Salary: " + e[1]);
            Console.WriteLine("Ename:" + e[2]);
            Console.WriteLine("Job:" + e[3]);
            Console.WriteLine("Dname:" + e[4]);
            Console.WriteLine("Location: " + e[5]);


            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Eno: " + e["Eno"]);
            Console.WriteLine("Salary: " + e["Salary"]);
            Console.WriteLine("Ename:" + e["Ename"]);
            Console.WriteLine("Job:" + e["Job"]);
            Console.WriteLine("Dname:" + e["Dname"]);
            Console.WriteLine("Location: " + e["Location"]);


            e["Location"] = "Lagos"; 

            Console.WriteLine("Location: " + e["Location"]);

            Console.ReadLine();
        }
    }
}
