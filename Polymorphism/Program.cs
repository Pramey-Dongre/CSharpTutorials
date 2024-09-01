using System.Text.Json;
Person person = new Person();
person.FirstName = "Ichigo";
person.LastName = "Kurosaki";
person.YearOfBirth = 2000;
Console.WriteLine(person);
string asJson = JsonSerializer.Serialize(person);
Console.WriteLine(asJson);
string personJson = "{\"FirstName\":\"Ichigo\",\"LastName\":\"Kurosaki\",\"YearOfBirth\":2000}";
Person personFromJson = JsonSerializer.Deserialize<Person>(personJson);
Console.WriteLine(personFromJson);
Console.ReadKey();
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
    public override string ToString() => $"Name is {FirstName} {LastName} and year of Birth is {YearOfBirth}";
}
//using Polymorphism.Extesnions;
//var multiLineString = @"dsrfgrg
//ssdsd
//ssdsdv
//sdfsdvd
//dsfgerbh
//dsrfgbrebred
//dsfgbvregber
//dfbdb
//dfgbdfs
//sfdv


//";

//int CountLines(string input) => input.Split(Environment.NewLine).Length;

//multiLineString.PrintStrings(); 
//Console.WriteLine("Count of Lines is: "+ multiLineString.CountLines());
//Console.WriteLine($"Next season after spring is {Season.Winter.NextSeason()}");


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

//List<Ingredient> ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new TomatoSauce(),
//    new Mozzarella()
//};
//foreach(Ingredient ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}
//Ingredient ingredient = new Cheddar();
//Console.WriteLine($"is object? {ingredient is object}");
//Console.WriteLine($"is Ingredient? {ingredient is Ingredient}");
//Console.WriteLine($"is Cheddar? {ingredient is Cheddar}");
//Console.WriteLine($"is TomatoSauce? {ingredient is TomatoSauce}");
//Console.WriteLine($"is Mozzarella? {ingredient is Mozzarella}");
//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine($"Random ingredient is {randomIngredient}");
//if (randomIngredient is Cheddar cheddar)
//{
//    Console.WriteLine("cheddar object: "+cheddar);
//}

//Ingredient ingredient = GenerateRandomIngredient();
//Cheddar cheddar = ingredient as Cheddar;
//Console.WriteLine(cheddar.Name);

//Ingredient GenerateRandomIngredient()
//{
//    var random = new Random();
//    var number = random.Next(1, 4);
//    if (number == 1) { return new Cheddar(2); }
//    if (number == 2) { return new TomatoSauce(4); }
//    return new Mozzarella(4);
//}
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredients(Ingredient ingredient) =>
        _ingredients.Add(ingredient);
    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
} 
public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public abstract void Prepare();
    public virtual string Name { get; } = "Some Ingredient";
}
public class Cheddar :Ingredient
{
    public Cheddar(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
    public override string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }

    public override void Prepare()
    {
        Console.WriteLine("Making cheddar");
    }
}
public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
    public string Name => "Tomato Sauce";
    public sealed override void Prepare()
    {
        Console.WriteLine("Making TOmato Soup");
    }
    public int AgedForMonths { get; }
}
public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
}
public sealed class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
    public override string Name => "Mozarella";
    public int IsLight { get; }
    public string sgsg => "wsfgsgf";
    public int AgedForMonths()
    {
        sgsg.Substring(sgsg.Length/2);
        sgsg.ToUpper();
        return 0;
    }

    public override void Prepare()
    {
        Console.WriteLine("Dicinggggg");
    }
}
//public class SpecialMozzarella : Mozzarella
//{

//}
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}