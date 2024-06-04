namespace Pizzeria;


public class Cheddar : Cheese {
    public Cheddar(int priceIfExtraTopping,int AgedForMonths) : base(priceIfExtraTopping)
    {
        this.AgedForMonths = AgedForMonths;
    }

    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a Cheddar cheese aged for {AgedForMonths} months";

    public int AgedForMonths { get; }

    public override void Prepare() =>
        Console.WriteLine("Grate and sprinkle over pizza.");

    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}
