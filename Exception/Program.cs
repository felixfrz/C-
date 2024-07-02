internal class Program
{
    private static void Main(string[] args)
    {

        
        
        try
        {
            Console.Write("Enter the 1st number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int second = int.Parse(Console.ReadLine());
            if(second == 1)
                return;
            int ans = first / second;
            Console.WriteLine(ans);
        }
        catch (DivideByZeroException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
        Console.WriteLine("Program End!!!!");
        Console.ReadLine();
    }
}