namespace Pizzeria;

public class SpecialTomatoSauce : TomatoSauce { 
    public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping) { }
    // We can overide but without overide it will compile as we know it is abstaract property but it is sealed by tomato class so we can now skip it
    //public override void Prepare() =>
    //    Console.WriteLine("Special tomato sauce");
}