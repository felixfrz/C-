internal class Program
{
     static void Main(string[] args)
    {


		try
		{
            Console.WriteLine("Add Two Numbers");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The answer is {x+y}");
        }
		catch (Exception e)
		{
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message); 
			Console.ForegroundColor = ConsoleColor.Green;
		}

        Console.ReadLine();
    }
}