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
            new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
            new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
            new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 1293 },
            new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 2873 },
            new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 6232 },
            new Employee() { EmpID = 106, EmpName = "Jessica", Job = "Manager", Salary = 4545 }
        ];

        //ElementAt
       Employee result =  employees.Where(employee=>employee.Job =="Manager").ElementAt(1);
        Console.WriteLine($"{result.EmpID}, {result.EmpName}, {result.Job}");


        //ElementAtOrDefault
        Employee? result2 = employees.Where(employee => employee.Job == "Manager").ElementAtOrDefault(1);

        if(result2 == null)
        {
            Console.WriteLine("No Manager at this index");
        }
        else
        {
            Console.WriteLine($"{result2.EmpID}, {result2.EmpName}, {result2.Job}");
        }
      

        Console.ReadKey();
    }
}