using SimpleFactory.Enum;
using SimpleFactory.Models;

namespace SimpleFactory.Factories;

internal class ProductFactory
{
    public static BaseProduct GetProduct(ProductType productType)
    {
        var productTypeDictionary = GetProductTypes();
        productTypeDictionary.TryGetValue(productType, out var product);
        return product;
    }

    private static Dictionary<ProductType, BaseProduct> GetProductTypes() =>
        new()
        {
            {ProductType.Local, new LocalProduct(1, "Notebook dell i3", "Eletronic Department", 30)},
            {ProductType.Online, new OnlineProduct(1, "Notebook acer i7", "notebook", "www.eletronics.com")}
        };
}