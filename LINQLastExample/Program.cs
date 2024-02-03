﻿class Employee
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }
    public string Job { get; set; }
    public double Salary { get; set; }
}


public class Program
{

    private static void Main(string[] args)
    {

        //Collection of objects
        List<Employee> employees =
        [
            new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
            new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
            new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 1293 },
            new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 2873 },
            new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 6232 },
            new Employee() { EmpID = 106, EmpName = "Jessica", Job = "Manager", Salary= 4545}
        ];

        //Where
        List<Employee> filteredLastEmployees = employees.Where(employee => employee.Job == "Manager").ToList();
        Console.WriteLine($"{filteredLastEmployees[filteredLastEmployees.Count -1].EmpID}, {filteredLastEmployees[filteredLastEmployees.Count - 1].EmpName}, {filteredLastEmployees[filteredLastEmployees.Count - 1].Job}");

        //Last
        Employee lastEmployee = employees.Last(employee => employee.Job == "Manager");
        Console.WriteLine($"{lastEmployee.EmpID}, {lastEmployee.EmpName}, {lastEmployee.Job}");


        //LastOrDefault
        var lastOrDefEmployee = employees.LastOrDefault(employee => employee.Job == "Manager");
        if(lastOrDefEmployee != null)
        {
            Console.WriteLine($"{lastOrDefEmployee.EmpID}, {lastOrDefEmployee.EmpName}, {lastOrDefEmployee.Job}");
        }
        else
        {
            Console.WriteLine("Job not found");
        }
       


        Console.ReadKey();
    }
}