class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        //read number from keyboard
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        //create object
        Sample s = new Sample();

        //call Factorial Method
        double fact = s.Factorial(n);
        Console.WriteLine($"Factorial of {n} is {fact}");
        Console.ReadKey();
        //n = 5
        //Factotial(5) = 5 * Factorial(4)
        //Factotial(4) = 4 * Factorial(3)
        //Factotial(3) = 3 * Factorial(2)
        //Factotial(2) = 2 * Factorial(1)
        //Factotial(1) = 1 * Factorial(0)
        //Factotial(0) = 1
    }
}