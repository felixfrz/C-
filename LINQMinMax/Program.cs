class Employee
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
            new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 900 },
            new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 1200 },
            new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 650 },
            new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 440 },
            new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 1100 },
            new Employee() { EmpID = 106, EmpName = "Jessica", Job = "Manager", Salary = 800 }
        ];

        //Min, Max, Sum, Average, Count
        double minValue = employees.Min(employee => employee.Salary);
        double maxValue = employees.Max(employee => employee.Salary);
        double sumValue = employees.Sum(employee => employee.Salary);
        double avgValue = employees.Average(employee => employee.Salary);
        double countValue = employees.Count();
        Console.WriteLine($"Min: {minValue}");
        Console.WriteLine($"Max: {maxValue}");
        Console.WriteLine($"Sum: {sumValue}");
        Console.WriteLine($"Average: {avgValue}");
        Console.WriteLine($"Count: {countValue}");


        Console.ReadKey();
    }
}