class Program
{
    static void Main()
    {
        //create theree object for Employee
        Employee emp1 = new Employee(101, "Frz", "Manager");
        Employee emp2 = new Employee(102, "Bim", "Asst. Manager");
        Employee emp3 = new Employee(103, "Scott", "Clerk");
        Employee emp4 = new Employee() { EmpName = "Ford", Job = "CEO" };

        //display fields
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine("\nFirst Employee: ");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Job);

        Console.WriteLine("Second Employee: ");
        Console.WriteLine(emp2.EmpID);
        Console.WriteLine(emp2.EmpName);
        Console.WriteLine(emp2.Job);

        Console.WriteLine("Third Employee: ");
        Console.WriteLine(emp3.EmpID);
        Console.WriteLine(emp3.EmpName);
        Console.WriteLine(emp3.Job);

        Console.WriteLine("Fourth Employee: ");
        Console.WriteLine(emp4.EmpID);
        Console.WriteLine(emp4.EmpName);
        Console.WriteLine(emp4.Job);

        Console.ReadKey();
    }
}
