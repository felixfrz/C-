using College;

internal class Program
{
    private static void Main()
    {
        //create object of student class
        Student student = new Student();
        student.RollNo = 1;
        student.StudentName = "Frz";
        student.Email = "frz@frzmail.com";
        student.examinations = new List<Examination>()
        {

            new Examination()
            {
                ExaminationName = "Module test 1", Month = 1, Year=2021, MaxMarks=100, SecuredMarks= 87
            },
             new Examination()
            {
                ExaminationName = "Module test 2", Month = 4, Year=2020, MaxMarks=100, SecuredMarks= 77
            },
              new Examination()
            {
                ExaminationName = "Module test 4", Month = 2, Year=2021, MaxMarks=100, SecuredMarks= 86
            },
               new Examination()
            {
                ExaminationName = "Module test 4", Month = 6, Year=2023, MaxMarks=100, SecuredMarks= 77
            },
        };

        Console.WriteLine(student.RollNo);
        Console.WriteLine(student.StudentName);
        Console.WriteLine(student.Email);

        foreach (var  examination in student.examinations)
        {
            Console.WriteLine($"{examination.ExaminationName} | {examination.Month} | {examination.Year} | {examination.MaxMarks} | {examination.SecuredMarks}");
       
        }
        Console.ReadKey();

    }
}