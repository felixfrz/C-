namespace Indexers
{
    internal class Employee
    {


        int _Eno;
        double _Salary;
        string _Ename, _Job, _Dname, _Location;

        public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
        {
            _Eno = Eno;
            _Salary = Salary;
            _Ename = Ename;
            _Job = Job;
            _Dname = Dname;
            _Location = Location;
        }


        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return _Eno;
                else if (index == 1)
                    return _Salary;
                else if (index == 2)
                    return _Ename;
                else if (index == 3)
                    return _Job;
                else if (index == 4)
                    return _Dname;
                else if (index == 5)
                    return _Location;
                return null;
            }
            set
            {
                if (index == 0)
                    _Eno = (int)value;
                else if (index == 1)
                    _Salary = (double)value;
                else if (index == 2)
                    _Ename = (string)value;
                else if (index == 3)
                    _Job = (string)value;
                else if (index == 4)
                    _Dname = (string)value;
                else if (index == 5)
                    _Location = (string)value;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return _Eno;
                else if (name.ToUpper() == "SALARY")
                    return _Salary;
                else if (name.ToUpper() == "ENAME")
                    return _Ename;
                else if (name.ToUpper() == "JOB")
                    return _Job;
                else if (name.ToUpper() == "DNAME")
                    return _Dname;
                else if (name.ToUpper() == "LOCATION")
                    return _Location;
                return null;
            }


            set
            {
                if (name.ToUpper() == "ENO")
                    _Eno = (int)value;
                else if (name.ToUpper() == "SALARY")
                    _Salary = (double)value;
                else if (name.ToUpper() == "ENAME")
                    _Ename = (string)value;
                else if (name.ToUpper() == "JOB")
                    _Job = (string)value;
                else if (name.ToUpper() == "DNAME")
                    _Dname = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    _Location = (string)value;

            }
        }


    }
}
