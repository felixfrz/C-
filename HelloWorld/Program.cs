public class Sample
{
    static void Main()
    {

        //local constant
        const string developerName = "Deji";
        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;


        //initialise field
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityStock = 3400;

        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityStock = 800;

        // get values from fields
        Console.WriteLine(developerName);
        Console.WriteLine("Product ID: " + product1.productID);
        Console.WriteLine("Product Name: " + product1.productName);
        Console.WriteLine("Cost: " + product1.cost);
        Console.WriteLine("Quantity Stock: " + product1.quantityStock);
        Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);

        Console.WriteLine("\nProduct ID: " + product2.productID);
        Console.WriteLine("Product Name: " + product2.productName);
        Console.WriteLine("Cost: " + product2.cost);
        Console.WriteLine("Quantity Stock: " + product2.quantityStock);
        Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);

        Console.WriteLine("\nProduct ID: " + product3.productID);
        Console.WriteLine("Product Name: " + product3.productName);
        Console.WriteLine("Cost: " + product3.cost);
        Console.WriteLine("Quantity Stock: " + product3.quantityStock);
        Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
        Console.WriteLine("Total no. of products: "+ Product.TotalNoProducts);
        Console.WriteLine("Category of products: " + Product.CategoryName);
    }
}


