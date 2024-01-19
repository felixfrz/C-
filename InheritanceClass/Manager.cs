
sealed public class Manager :IPerson,  IEmployee
{
    //field
    private string _departmentName;
    private int _empID;
    private string _empName;
    private string _location;
    private System.DateTime _dateOfBirth;


    //properties
    public int EmpID
    {
        set
        {
            if (value >= 1000 && value <= 2000)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }
    public string EmpName { 
        set { _empName = value; } 
        get { return _empName; }
    }
    public string Location { set { _location = value; } get { return _location; } }


    public System.DateTime DateOfBirth
    {
        set { _dateOfBirth = value; }
        get { return _dateOfBirth; }
    }

    public string DepartmentName
    {
        set { _departmentName = value; }
        get { return _departmentName; }
    }

    //constructor
    public Manager(int empID, string empName, string location, string department)
    {


        _empID = empID;
        _empName = empName;
        _location = location;
        _departmentName = department;

    }



    //method
    public long GetTotalSaleSalesOfYear()
    {
        return 1000;
    }

    //method
    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + _location;
    }



   

    //method implementation the abstract methods
    public string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is 1000";
    }



 public int GetAge()
    {
      int a =  System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }

  

}


//public class BranchManager: Manager
//{

//}


