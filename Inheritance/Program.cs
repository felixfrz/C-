class Sample
{
    public static void Main()
    {


        IPerson person;
        person = new Manager(102, "Allen", "New York", "Accounting");
        person.GetAge();
    }
}