
public class Program
{
    public static void Main(string[] args)
    {
        //reference Variable
        Customer c1, c2;

        //objects
        c1 = new Customer();
        c2 = new Customer();

        //create reference Variable
        Product product1, product2, product3;

        //create Objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initialise fields
        product1.productID = 1001;
        product1.productName = "Mobile";

        Product.TotalNoProducts++;
        Product.TotalNoProducts++;
         
        Console.WriteLine(  Product.TotalNoProducts);

        Console.ReadKey();
    }
}