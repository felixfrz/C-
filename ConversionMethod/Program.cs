class Program
{
    static void Main()
    {
        //int
        int a = 1000;

        //string
        string b;

        //int --> string
        b = Convert.ToString(a);

        Console.WriteLine(a);// --> 1000 as int
        Console.WriteLine(b);// ---> 1000 as string

        Console.ReadKey();
    }
}