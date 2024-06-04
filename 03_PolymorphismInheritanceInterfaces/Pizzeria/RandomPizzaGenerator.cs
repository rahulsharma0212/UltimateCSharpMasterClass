namespace Pizzeria;

//public class SpecialPizza : Mozzarella
//{

//}

public static class RandomPizzaGenerator
{
    public static Pizza Generate(int howManyIngredient) {
        var pizza = new Pizza();
        for(int i = 0; i < howManyIngredient; i++)
        {
            var randomIngredient = GenerateRandomIngredient();
            pizza.AddIngredient(randomIngredient);
        }
        return pizza;
    }

    public static Ingredient GenerateRandomIngredient() {
        var random = new Random();
        var number = random.Next(1, 4);
        switch (number)
        {
            case 1:
                return new Cheddar(2,12);
            case 2:
                return new TomatoSauce(1);
            default:
                return new Mozzarella(2);
        }
    }
}