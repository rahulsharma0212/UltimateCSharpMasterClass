namespace Pizzeria;

public class Panetone : Dessert, IBakeable
{
    public string GetInstruction()
    {
        return "Bake at 180 degrees Celsius for 35 minutes.";
    }
}