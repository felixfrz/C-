var messages = new Queue<string>();

messages.Enqueue(".Net is awesome!!!");
messages.Enqueue("C# is a great programming language");


messages.Dequeue();


foreach (var message in messages)
{
    Console.WriteLine(message);
}

Console.ReadKey();