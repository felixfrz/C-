

public class Product
{
    // fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;


    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    
    }
}


