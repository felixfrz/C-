using Beginners;
using System.IO;

public class Program
{
    public static void Main()
    {
        List<User> users = new List<User>();


        User user1 = new User("frz", 23);
        User user2 = new User("Deji", 63);
        User user3 = new User("Ayo", 93);

        users.Add(user1);
        users.Add(user2);
        users.Add(user3);

     


        foreach (var user in users)
        {
          

        
            Console.WriteLine(user.Name);
        }
        Console.ReadKey();
    }
}