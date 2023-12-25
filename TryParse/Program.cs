class Program
{
    static void Main()
    {
        // read in from the keyboard
        string s;

        Console.WriteLine("Enter a number: ");
        s = Console.ReadLine();

        //TryParse
       bool b =  int.TryParse(s, out int n);

        if(b == true)
        {
            Console.WriteLine("Conversion is successful");
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Conversion failed");
        }

        Console.ReadKey();
    }
}