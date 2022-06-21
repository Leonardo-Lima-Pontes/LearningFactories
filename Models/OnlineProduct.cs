namespace SimpleFactory.Models;

internal class OnlineProduct : BaseProduct
{
    public OnlineProduct(int id, string name, string label, string website) : base(id, name)
    {
        Label = label;
        Website = website;
        
        ShowCreationProduct();
    }

    private string Label { get; }
    private string Website { get; }
    
    public sealed override void ShowCreationProduct() => 
        Console.WriteLine($"Local product: {Id} - {Name} created, showing the label {Label}, at the the website {Website}");
}