class Program
{
    static void Main()
    {
        //create theree object for Employee
        Employee emp1 = new Employee(101, "Frz", "Manager");
        emp1.Tax = 50;
        emp1.NativePlace = "Akure";
        Employee emp2 = new Employee(102, "Bim", "Asst. Manager");
        Employee emp3 = new Employee(103, "Scott", "Clerk");
        Employee emp4 = new Employee() { EmpName = "Ford", Job = "CEO" };

        //display fields
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine("\nFirst Employee: ");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Job);
        Console.WriteLine(emp1.Salary);
        Console.WriteLine(emp1.CalculateNetSalary());
        Console.WriteLine(emp1.NativePlace);
        //emp1.Salary = 29944;
        Console.WriteLine();

        Console.WriteLine("Second Employee: ");
        Console.WriteLine(emp2.EmpID);
        Console.WriteLine(emp2.EmpName);
        Console.WriteLine(emp2.Job);
        Console.WriteLine(emp2.Salary);
        Console.WriteLine();

        Console.WriteLine("Third Employee: ");
        Console.WriteLine(emp3.EmpID);
        Console.WriteLine(emp3.EmpName);
        Console.WriteLine(emp3.Job);
        Console.WriteLine(emp2.Salary);
        Console.WriteLine();

        Console.WriteLine("Fourth Employee: ");
        Console.WriteLine(emp4.EmpID);
        Console.WriteLine(emp4.EmpName);
        Console.WriteLine(emp4.Job);
        Console.WriteLine(emp2.Salary);

        Console.ReadKey();
    }
}
