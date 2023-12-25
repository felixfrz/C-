

public class Product
{
    // fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    // Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();

    }

    //set method for productID
    public void SetProductID(int value)
    {
        productID = value;
    }
    // get method for productID
    public int GetProductID()
    {
        return productID;
    }

    //set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }
    // get method for productName
    public string GetProductName()
    {
        return productName;
    }

    //set method for cost
    public void SetCost(double value)
    {
        cost = value;
    }
    // get method for cost
    public double GetCost()
    {
        return cost;
    }


    //set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }
    // get method for tax
    public double GetTax()
    {
        return tax;
    }


    //calulateTax method to calculate tax
    //cost <=20000 then tax = 10%
    //cost > 20000 then tax = 12.5%

    public void CalculateTax(in double percentage)
    {
      //  percentage = 10.45;
        //create local variable
        double t;

        //calculate tax
        if (this.cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }


    public void CalculateTax(double cost, double percentage)
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }


    //set method for quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityStock = value;
    }
    // get method for quantityInStock
    public int GetQuantityInStock()
    {
        return quantityStock;
    }

    // get method for dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }



    // set method for TotalNoOfProduct
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    // get method for TotalNoOfProduct
    public static int GetTotalNoOfProducts() => TotalNoProducts;

    //static method: Calculates total quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }

}


