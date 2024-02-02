

using Extension2ClassLibrary2;

namespace ExtensionMethod2
{

    //static class for exxtension method
    public static class ProductExtensions
    {

        // extension method for product class
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
