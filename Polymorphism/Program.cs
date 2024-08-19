//Pizza pizza = new Pizza();
//pizza.AddIngredients(new Cheddar());
//pizza.AddIngredients(new TomatoSauce());
//pizza.AddIngredients(new Mozarella());
//Console.WriteLine(pizza.Describe());

//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

List<Ingredient> ingredients = new List<Ingredient>
{
    new Cheddar(),
    new TomatoSauce(),
    new Mozzarella()
};
foreach(Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}
Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredients(Ingredient ingredient) =>
        _ingredients.Add(ingredient);
    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
} 
public class Ingredient
{
    public virtual string Name { get; } = "Some Ingredient";
}
public class Cheddar :Ingredient
{
    public override string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }
}
public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int AgedForMonths { get; }
}
public class Mozzarella : Ingredient
{
    public override string Name => "Mozarella";
    public int IsLight { get; }
    public string sgsg => "wsfgsgf";
    public int AgedForMonths()
    {
        sgsg.Substring(sgsg.Length/2);
        sgsg.ToUpper();
        return 0;
    }
}