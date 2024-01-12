public class Employee
{
    //
    private int _empID;
    private string _empName;
    private string _job;


    //instance property
    public int EmpID
    {
        set
        {
            if (value >= 100)
            {
                _empID = value;
            }

        }
        get { return _empID; }
    }

    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }


    //static fileld
    private static string _companyName;


    //static property
    public static string CompanyName
    {
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }

    // instance constructor // constructor 1
    public Employee(int empID, string empName, string job)
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
    }
    // constructor 2
    public Employee(int empID, string empName)
    {
        this._empID = empID;
        this._empName = empName;
    }

    // constructor 3
    public Employee()
    {
        _empID = 1;
    }
    //static constructor
    static Employee()
    {
        _companyName = "ABC Industries";
    }
}