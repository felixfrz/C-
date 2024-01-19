class Sample
{
    public static void Main()
    {


        IEmployee emp;
        emp = new Manager(102, "Allen", "New York", "Accounting");
        emp.GetAge();

        Console.WriteLine(emp.DateOfBirth);


        IPerson person;
        person = new Manager(102, "Allen", "New York", "Accounting");
        person.GetAge();

        Console.WriteLine(person.DateOfBirth);



        Console.ReadKey();
    }
}