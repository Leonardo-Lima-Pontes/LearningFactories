namespace SimpleFactory.Models;

internal abstract class BaseProduct
{
    protected BaseProduct(int id, string name)
    {
        Id = id;
        Name = name;
    }

    protected int Id { get; }
    protected string Name { get; }

    public abstract void ShowCreationProduct();
}