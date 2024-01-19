


public class Salesamn : IEmployee
{
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;



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

    //method implementation the abstract methods
    public string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is 500";
    }
}


