class Program
{
    static void Main()
    {
        //create theree object for Employee
        Employee emp1 = new Employee(101, "Frz", "Manager");
        Employee emp2 = new Employee(102, "Bim", "Asst. Manager");
        Employee emp3 = new Employee(103, "Scott", "Clerk");

        //display fields
        Console.WriteLine(Employee.companyName);
        Console.WriteLine("\nFirst Employee: ");
        Console.WriteLine(emp1.empID);
        Console.WriteLine(emp1.empName);
        Console.WriteLine(emp1.job);

        Console.WriteLine("Second Employee: ");
        Console.WriteLine(emp2.empID);
        Console.WriteLine(emp2.empName);
        Console.WriteLine(emp2.job);

        Console.WriteLine("Third Employee: ");
        Console.WriteLine(emp3.empID);
        Console.WriteLine(emp3.empName);
        Console.WriteLine(emp3.job);

        Console.ReadKey();
    }
}
