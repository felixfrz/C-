


public class Salesamn : IPerson, IEmployee
{
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;
    private System.DateTime _dateOfBirth;



    //properties
    public int EmpID
    {
        set
        {
            if (value >= 500 && value < 1000)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }
    public string EmpName { set { _empName = value; } get { return _empName; } }
    public string Location { set { _location = value; } get { return _location; } }

    public Salesamn(int empID, string empName, string location, string region)
    {
       _empID = empID;
        _empName = empName;
        _location = location;
        _region = region;

    }

    public System.DateTime DateOfBirth
    {
        set { _dateOfBirth = value; }
        get { return _dateOfBirth; }
    }

    //method implementation the abstract methods
    public string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is 500";
    }

    public int GetAge()
    {
        int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }
}


