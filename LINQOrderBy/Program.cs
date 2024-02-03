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


        List<Employee> employees =
        [
            new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
            new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
            new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 1293},
            new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 2873 },
            new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 6232 },
        ];

        IEnumerable<Employee> result = employees.OrderBy((employee) => employee.EmpName);
        foreach(Employee item in result)
        {
            Console.WriteLine($"{item.EmpID}, {item.EmpName}, {item.Job}, {item.Salary}");
        }

        Console.ReadKey();

        //List<Employee> employees = new List<Employee>()
        //{
            //new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
            //new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
            //new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 1293 },
            //new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 2873 },
            //new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 6232 },
        //};
    }
}