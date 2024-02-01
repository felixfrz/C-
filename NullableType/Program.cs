//System.Nullable<int> age = null;

int? age = null;

if (age.HasValue)
{
    Console.WriteLine(age.Value);
}
else
{
    Console.WriteLine("Age has not been set.");
}


Console.ReadKey();