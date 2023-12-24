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
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//3


        //initialise field
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);

        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);

        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        //call method
        product1.CalculateTax(9.2);
        product2.CalculateTax(7.4);
        product3.CalculateTax();

        // get values from fields
        Console.WriteLine(developerName);
        Console.WriteLine("Product1:");
        Console.WriteLine("Product ID: " + product1.GetProductID());
        Console.WriteLine("Product Name: " + product1.GetProductName());
        Console.WriteLine("Cost: " + product1.GetCost());
        Console.WriteLine("Quantity Stock: " + product1.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product1.GetTax());

        Console.WriteLine("\nProduct2:");
        Console.WriteLine("Product ID: " + product2.GetProductID());
        Console.WriteLine("Product Name: " + product2.GetProductName());
        Console.WriteLine("Cost: " + product2.GetCost());
        Console.WriteLine("Quantity Stock: " + product2.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product2.GetTax());

        Console.WriteLine("\nProduct3:");
        Console.WriteLine("Product ID: " + product3.GetProductID());
        Console.WriteLine("Product Name: " + product3.GetProductName());
        Console.WriteLine("Cost: " + product3.GetCost());
        Console.WriteLine("Quantity Stock: " + product3.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product3.GetTax());

        //total Quantity
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);


        Console.WriteLine("Total no Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);

        Console.WriteLine("Category of products: " + Product.CategoryName);



        Console.ReadKey();
    }
}


