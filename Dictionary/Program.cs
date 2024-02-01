var grades = new Dictionary<int, string>
{
    {6, "Perfect" }
};

grades.Add(5, "Good");
grades[4] = "Okay";
grades[3] = "Almost";
grades.Add(2, "Bad");
grades[1] = "Worse";

grades.Remove(5);

foreach(var grade in grades)
{
    Console.WriteLine($"{grade.Key}: {grade.Value}");
}

Console.WriteLine(grades.ContainsKey(4));
Console.WriteLine(grades.ContainsValue("Good"));

Console.ReadKey();