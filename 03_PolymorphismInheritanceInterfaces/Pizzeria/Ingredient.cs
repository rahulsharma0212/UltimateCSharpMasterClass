namespace Pizzeria;

public abstract class Ingredient {

    public int PriceIfExtraTopping { get;}
    public virtual string Name { get; } = "Some Ingredient";
    public override string ToString() => Name;

    public abstract void Prepare();

    public int PublicField;
    public Ingredient(int priceIfExtraTopping) {
        Console.WriteLine("Constructor from the ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is PUBLIC in the Ingredient class.";
    private string PrivateMethod() => "This method is PUBLIC in the Ingredient class.";

}