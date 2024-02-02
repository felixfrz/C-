using College;

public class Program
{
    private static void Main()
    {
        //Student class object
        Student student = new Student();
        student.RollNo = 123;
        student.StudentName = "Frz";
        student.Email = "frz@frzmail.com";


        //Branch class object
        //Branch br = new Branch();
        //br.BranchName = "CS";
        //br.NoOfSemester = 8;


        //one-to-one relationship

        student.branch = new Branch()
        {
            BranchName = "CS",
            NoOfSemester = 8
        };

        //display
        Console.WriteLine(student.StudentName);
        Console.WriteLine(student.RollNo);
        Console.WriteLine(student.Email);
        Console.WriteLine(student.branch.BranchName);
        Console.WriteLine(student.branch.NoOfSemester);

        Console.ReadKey();
    }
}