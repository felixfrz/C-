

using Extension2ClassLibrary2;

namespace ExtensionMethod2
{
    static class AdditionalExtension
    {

        public static int Add(this Product product, int a, int b)
        {
            return Convert.ToInt32(product.ProductCost + a + b);
        }
    }
}
