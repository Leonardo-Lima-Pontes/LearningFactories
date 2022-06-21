namespace SimpleFactory.Models;

internal class LocalProduct : BaseProduct
{
    public LocalProduct(int id, string name, string local, int quantity) : base(id, name)
    {
        Local = local;
        Quantity = quantity;
        
        ShowCreationProduct();
    }

    private string Local { get; }
    private int Quantity { get; }

    public sealed override void ShowCreationProduct() => 
        Console.WriteLine($"Local product: {Id} - {Name} created, with {Quantity} in inventory, at the local {Local}");
}