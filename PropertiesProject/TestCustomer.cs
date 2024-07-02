

namespace PropertiesProject
{
    internal class TestCustomer
    {

        static void Main()
        {
            Customer c = new Customer(101, false, "Felix", 5000.00, Cities.Bengaluru, "Karnakata");



            Console.WriteLine("Customer ID: " + c.CustId);
            if (c.Status == true)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active");

            Console.WriteLine("Customer Name: " + c.CName);

            c.CName += " Deji";

            Console.WriteLine("Modified Customer Name: " + c.CName);
            Console.WriteLine("Customer Balance: " + c.Balance);


            Console.WriteLine("==============================");


            c.Status = true;

            if (c.Status == true)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active");

            Console.WriteLine("Customer Name: " + c.CName);

            c.CName += " Deji";

            Console.WriteLine("Modified Customer Name: " + c.CName);
            c.Balance -= 3000;

            Console.WriteLine("Balance when assignment succeds " + c.Balance);

            c.Balance -= 1800;
            Console.WriteLine("Balance when assignment failed " + c.Balance);
            
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Current City: " + c.City);
            c.City = Cities.Hyderabad;
            Console.WriteLine("Modified City: " + c.City);

            Console.WriteLine("Current State: " + c.State);
            // c.State = "Telangana";
            Console.WriteLine("Country: " + c.Country);
            
            Console.ReadLine();
        }
    }
}
