namespace Pizzeria;

public class Pizza:IBakeable {

    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) {
        _ingredients.Add(ingredient);
    }

    public string GetInstruction() {
        return "Bake at 250 degrees Celsius for 10 minutes";
    }

    public override string ToString()
    {
        return $"This is a Pizza with {string.Join(", ", _ingredients)}";
    }

}
