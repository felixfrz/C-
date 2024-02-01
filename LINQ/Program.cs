var numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8 };


var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}



var animals = new List<string> { "Deer", "Sheep", "Goat", "Bull", "Dog", "Cat", "Elephant", "Zebra" };

foreach (var animal in animals.OrderBy(animal => animal))
{
    Console.WriteLine(animal);
};

Console.WriteLine();

foreach (var animal in animals.OrderByDescending(animal => animal))
{
    Console.WriteLine(animal);
}

Console.WriteLine();


var persons = new List<Person>
{
    new Person("Adebola", "John"),
    new Person("Bola", "Wellber"),
    new Person("John", "Deer"),
    new Person("John", "Apple")
};

foreach (var person in persons.OrderBy(person => person.FirstName).ThenBy(person => person.LastName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
};


Console.ReadKey();

record Person(string FirstName, string LastName);