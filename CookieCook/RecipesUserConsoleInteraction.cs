using CookieCook.Recipes;
using CookieCook.Recipes.Ingredients;

public class RecipesUserConsoleInteraction : IRecipesUserInteraction
{
    public RecipesUserConsoleInteraction(
        IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    private readonly IngredientsRegister _ingredientsRegister;
    public void ShowMessage(string message) 
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to Exit.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0) 
        {
            Console.WriteLine("Existing Recipes are:"
                + Environment.NewLine);
            int i = 1;
            foreach(Recipe recipe in allRecipes)
            {
                Console.WriteLine($"**********{i++}***********");
                Console.WriteLine(recipe);
                Console.WriteLine();
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new Cookie Recipe!"+
            "Available ingredients are:");
        foreach(var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }
}

public class IngredientsRegister
{
    public IEnumerable<Ingredient> All { get; }= new List<Ingredient>
    { 
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };    
}