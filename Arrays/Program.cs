


//Arrays and Collections


int[] array1 = new int[4];

array1[0] = 7;
array1[1] = 6;
array1[2] = 5;
array1[3] = 4;

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

//Array initializer
int[] array2 = new int[] { 34, 67, 86, 3 };

var array3 = new int[] { 09, 45, 97, 23 };

Console.WriteLine(array2[1]);
Console.WriteLine(array3[1]);

//Alternative Syntax
int[] array4 = { 657, 959, 23, 89 };
Console.WriteLine(array4[2]);


var p1 = new Person[2];
p1[0] = new Person("frz");
p1[1] = new Person("demo");


Person[] p2 = new Person[2];
p2[0] = new Person("yoshi");
p2[1] = new Person("ryu");


Person[] p3 = { new Person("des"), new Person("ken") };
p3[0].Name = "Test";

//for loop
for (int i = 0; i < p2.Length; i++)
{
    Console.WriteLine($"Name: {p2[i].Name}");
}

//foreach
foreach (Person p in p1)
{
    Console.WriteLine(p.Name);
}

//While loop
int j = 0;
while (j < p3.Length)
{
    Console.WriteLine(p3[j].Name);
    j++;
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