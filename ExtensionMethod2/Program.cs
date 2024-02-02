using Extension2ClassLibrary2;
using ExtensionMethod2;

internal class Program
{
    private static void Main(string[] args)
    {

        //create object
        Product product = new Product() { ProductCost = 1000, DiscountPercentage = 10};

        var prodAdd = new Product
        {
            ProductCost = 60,
        };

        Console.WriteLine(prodAdd.Add(2,3));

        //call the extension method
        Console.WriteLine(product.GetDiscount());

        Console.ReadKey();
    }
}