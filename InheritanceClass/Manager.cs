﻿
sealed public class Manager : Employee
{
    //field
    private string _departmentName;


    //properties

    public string DepartmentName
    {
        set { _departmentName = value; }
        get { return _departmentName; }
    }

    //method
    public long GetTotalSaleSalesOfYear()
    {
        return 1000;
    }

    //method
    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + base.Location;
    }

    //method overriding the abstract methods
    public override string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is 1000";
    }

}


//public class BranchManager: Manager
//{

//}


