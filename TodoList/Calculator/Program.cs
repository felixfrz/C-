
using System.Runtime.InteropServices;

Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract number");
Console.WriteLine("[M]ultuply numbers");

string option = Console.ReadLine();

if (option == "A".ToLower())
{
    Add(firstNumber, secondNumber);

}else if (option == "S".ToLower())
{
    Subtract(firstNumber, secondNumber);
}else if(option == "M".ToLower())
{
    Multiple(firstNumber, secondNumber);
}
else
{
    Console.WriteLine("Invalid option");
}
Console.WriteLine("Press any key to close");


void Add(int a, int b)
{
    Console.WriteLine($"{a} + {b} = " + (a+b));
};

void Subtract(int a, int b)
{
    Console.WriteLine($"{a} - {b} = " + (a - b));
};

void Multiple(int a, int b)
{
    Console.WriteLine($"{a} * {b} = " + (a * b));
};

Console.ReadKey();
