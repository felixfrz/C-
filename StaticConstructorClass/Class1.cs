public class Employee
{
    //
    public int empID;
    public string empName;
    public string job;

    //static fileld
    public static string companyName;

    // instance constructor // constructor 1
    public Employee(int empID, string empName, string job)
    {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }
    // constructor 2
    public Employee(int empID, string empName)
    {
        this.empID = empID;
        this.empName = empName;
    }

    // constructor 3
    public Employee()
    {
        empID = 1;
    }
    //static constructor
    static Employee()
    {
        companyName = "ABC Industries";
    }
}