class Student
{

    public void DisplaySubjects(params string[] subjects)
    {

        //foreach (string i in subjects)
        //{

        //    Console.WriteLine(i);
        //}

        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }

        Console.ReadKey();
    }

}

class Program
{
    static void Main()
    {
        Student s = new Student();


        s.DisplaySubjects("ffdddg", "hdgdggdd", "dcdfdd", "frrddtdt", "etefy", "teefe");
    }
}
