





using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList al = new ArrayList(2);

        Console.WriteLine(al.Capacity);

        al.Add(200); 
        al.Add(500); 
        al.Add(900); 
        al.Add(600);

        Console.WriteLine(al.Capacity);

        foreach(object o in al) 
            Console.WriteLine(o);
        Console.WriteLine();


        al.Insert(2, 350);



        foreach (object o in al)
            Console.WriteLine(o);

       

        Console.ReadLine();

    }
}