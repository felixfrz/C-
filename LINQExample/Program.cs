class Employee
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }
    public string Job { get; set; }
    public string City { get; set; }
}


public class Program
{

    private static void Main(string[] args)
    {
       

        List<Employee> employees =
        [
            new Employee(){EmpID = 101, EmpName= "Henry", Job="Designer", City="Boston"},
            new Employee(){EmpID = 102, EmpName= "Jack", Job="Developer", City="New York"},
            new Employee(){EmpID = 103, EmpName= "Gabriel", Job="Analyst", City="Tokyo"},
            new Employee(){EmpID = 104, EmpName= "William", Job="Manager", City="Tokyo"},
            new Employee(){EmpID = 105, EmpName= "Alexa", Job="Manager", City="Washington"},
        ];

        //var result =  employees.Where(employee => employee.Job == "Manager");
        var result = employees.Where((employee) => employee.City == "Tokyo");
        foreach(var item in result)
        {
            Console.WriteLine($"{item.EmpID}, {item.EmpName}, {item.Job}, {item.City}");
        }

        Console.ReadKey();

        //List<Employee> employees = new List<Employee>()
        //{
        //    new Employee(){EmpID = 101, EmpName= "Henry", Job="Designer", City="Boston"},
        //    new Employee(){EmpID = 102, EmpName= "Jack", Job="Developer", City="New York"},
        //    new Employee(){EmpID = 103, EmpName= "Gabriel", Job="Analyst", City="Tokyo"},
        //    new Employee(){EmpID = 104, EmpName= "William", Job="Manager", City="Tokyo"},
        //    new Employee(){EmpID = 105, EmpName= "Alexa", Job="Asst.Manager", City="Washington"},
        //};
    }
}