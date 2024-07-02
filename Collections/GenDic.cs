using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colle
{


    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Mark { get; set; }


        public int CompareTo(Student? other)
        {
            if (this.Id > other.Id)
                return 1;
            else if (this.Id < other.Id)
                return -1;
            return 0;
        }
    }

    class CompareStudent : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Mark > y.Mark)
                return 1;
            else if (x.Mark < y.Mark)
                return -1;
            return 0;
        }
    }
    class Test
    {
        public static int CompareNames(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }


        static void Main()
        {
            Student s1 = new Student() { Id = 100, Name = "Wirz", Mark = 78.7f };
            Student s2 = new Student() { Id = 101, Name = "Des", Mark = 69.07f };
            Student s3 = new Student() { Id = 102, Name = "Fel", Mark = 90.2f };
            Student s4 = new Student() { Id = 103, Name = "Ayo", Mark = 88.7f };
            Student s5 = new Student() { Id = 104, Name = "Bim", Mark = 50.07f };
            Student s6 = new Student() { Id = 105, Name = "Char", Mark = 40.2f };

            List<Student> students = new List<Student> { s5, s2, s6, s4, s1, s3 };


            //CompareStudent compareStudent = new CompareStudent();
            //students.Sort(compareStudent);
            //students.Sort(1, 5, compareStudent);

            //students.Sort();
            //students.Reverse();


            Comparison<Student> obj = new Comparison<Student>(CompareNames);

            students.Sort(obj);
            students.Reverse();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Mark}");
            }

            Console.ReadLine();
        }
    }

}
