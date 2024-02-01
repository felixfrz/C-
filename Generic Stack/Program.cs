


var countries = new Stack<string>();

countries.Push("Nigeria");
countries.Push("Ghana");
countries.Push("S.Africa");


countries.Pop();


foreach (var country in countries)
{
    Console.WriteLine(country);
}

Console.ReadKey();