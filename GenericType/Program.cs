

var cities = new RandomItemGenerator<string>();

cities.Add("Lagos");
cities.Add("Port Harcourt");
cities.Add("Akure");

for (int i = 0; i < 10; i++)
{
    var randomCity = cities.Get();
    Console.WriteLine(randomCity);
}

RandomItemGenerator<int> numbers = new RandomItemGenerator<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);


for(int j = 0; j < 10; j++)
{
    var randomNumber = numbers.Get();
    Console.WriteLine(randomNumber);
}




Console.ReadKey();

public class RandomItemGenerator<T>
{
    private readonly List<T> _items = new List<T>();
   
    private readonly Random _random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        var index = _random.Next(0, _items.Count);
        return _items[index];
    }
}