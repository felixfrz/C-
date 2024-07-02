using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{

    public class Teacher
    {
        int _Id;
        string? _Name, _Subject, _Designation;
        double? _Salary;

        public  Teacher (int Id, string? Name,string? Subject, string? Designation, double? Salary)
        {
            _Id = Id;
            _Name = Name;
            _Subject = Subject;
            _Designation = Designation;
            _Salary = Salary;
        }

        public void Deconstruct(out int Id, out string? Name, out string? Subject, out string? Designation, out double? Salary)
        {
            Id = _Id;
            Name = _Name;
            Subject = _Subject;
            Designation = _Designation;
            Salary = _Salary;
        }

        public void Deconstruct(out int Id, out string? Subject, out double? Salary)
        {
            Id= _Id;
            Subject= _Subject;
            Salary= _Salary;    
        }

          
    }
    internal class TestTeacher
    {
        static void Main()
        {
            Teacher obj = new Teacher(1005, "Frz", "Coding", "Snr. Developer", 47000);

            (int Id1, string? Name1, string? Subject1, string? Designation1, double? Salary1) = obj;

            Console.WriteLine(" Teacher Id: " +Id1);
            Console.WriteLine(" Teacher Name: " +Name1);
            Console.WriteLine(" Teacher Subject: " +Subject1);
            Console.WriteLine(" Teacher Designation: " +Designation1);
            Console.WriteLine(" Teacher Salary: " +Salary1 + "\n ");


            (var Id2, var Name2, var Subject2, var Designation2, var Salary2) = obj;

            Console.WriteLine(" Teacher Id: " + Id1);
            Console.WriteLine(" Teacher Name: " + Name1);
            Console.WriteLine(" Teacher Subject: " + Subject1);
            Console.WriteLine(" Teacher Designation: " + Designation1);
            Console.WriteLine(" Teacher Salary: " + Salary1 + "\n ");




          var (Id3, Name3, Subject3, Designation3, Salary3) = obj;

            Console.WriteLine(" Teacher Id: " + Id3);
            Console.WriteLine(" Teacher Name: " + Name3);
            Console.WriteLine(" Teacher Subject: " + Subject3);
            Console.WriteLine(" Teacher Designation: " + Designation3);
            Console.WriteLine(" Teacher Salary: " + Salary3 + "\n ");


            var (Id4, Subject4, Salary4) = obj;

            Console.WriteLine(" Teacher Id: " + Id4);
            Console.WriteLine(" Teacher Subject: " + Subject4);
            Console.WriteLine(" Teacher Salary: " + Salary4 + "\n ");


            var (Id5, Name5, _, _, _) = obj;
            Console.WriteLine(" Teacher Id: " + Id5 + "\n ");
            Console.ReadLine();
        }
    }
}
