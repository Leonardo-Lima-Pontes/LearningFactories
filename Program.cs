using SimpleFactory.Enum;
using SimpleFactory.Factories;

var localProduct = ProductFactory.GetProduct(ProductType.Local);
var onlineProduct = ProductFactory.GetProduct(ProductType.Online);