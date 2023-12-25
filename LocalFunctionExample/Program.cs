class Student
{
    public void DisplayMarks(int mark1, int mark2, int mark3)
    {
        double avgMarks = getAverageMarks(mark1, mark2, mark3);
        Console.WriteLine("Marks 1: " + mark1);
        Console.WriteLine("Marks 2: " + mark2);
        Console.WriteLine("Marks 3: " + mark3);
        Console.WriteLine("Average marks: " + avgMarks);

        //create static local function

        static double getAverageMarks(int m1, int m2, int m3)
        {
            //create local variable of local function
            double avg;
            avg = (double)(m1 + m2 + m3) / 3;
            return avg;
        }
    }
}

class Program
{
    public static void Main()
    {
        //create object for Student class
        Student s = new Student();

        //calling DisplayMark Method
        s.DisplayMarks(80, 45, 71);


        Console.ReadKey();
    }

}