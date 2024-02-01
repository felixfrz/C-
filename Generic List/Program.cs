
var numbers = new List<int>();
int day = 24;
numbers.Add(day);
numbers.Add(78);


List<int> hours = new List<int>
{
    1,3,4,5,6,7,8,9,10,11,12,
};


for(int i = 0; i < hours.Count; i++)
{
    Console.WriteLine(hours[i]);
}


foreach(var number in numbers)
{
    Console.WriteLine($"{number}");
}

Person p1 = new Person("Frz");
var p2 = new Person("Des");

var PersonList = new List<Person>();
PersonList.Add(p1);
PersonList.Add(p2);

foreach(var person in PersonList)
{
    Console.WriteLine(person.Name);
}




Console.ReadKey();


public class Person
{


    public string Name { get; set; }

    public Person(string name)
    {

        Name = name;

    }
}