

var person = new Person("Frz", "Wilson");
Console.WriteLine(person.ToFullName());
Console.WriteLine(person.HasId());
Console.ReadKey();
public interface Identification
{
    int Id { get;}
}


public static class IdentificationExtension
{
    public static bool HasId(this Identification identification)
    {
        return identification.Id > 0;
    }
}

public class Person : Identification
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id
    {
        get
        {
            return 7;
        }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

};