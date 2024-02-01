

public static class PersonExtension
{
    public static string ToFullName(this Person person)
    {
        return $"{person.FirstName} {person.LastName}";
    }
}
