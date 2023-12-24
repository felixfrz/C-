

public class Product
{
    // fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

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

    public void CalculateTax()
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
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


}


