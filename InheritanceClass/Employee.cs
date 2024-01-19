
public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _location;



    //properties
    public int EmpName
    {
        set { _empID = value; }
        get { return _empID; }
    }

    public string Location
    {
        set { _location = value; }
        get { return _location; }
    }
}

