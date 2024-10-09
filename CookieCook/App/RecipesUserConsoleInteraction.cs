using CookieCook.Recipes;
using CookieCook.Recipes.Ingredients;

public class RecipesUserConsoleInteraction : IRecipesUserInteraction
{
    private readonly IIngredientsRegister _ingredientsRegister;
    public RecipesUserConsoleInteraction(
        IIngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
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

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        bool shallStop = false;
        List<Ingredient> ingredients = new List<Ingredient>();
        while (!shallStop) 
        {
            Console.WriteLine("Add an ingredient by its ID, "+
                "or type anything if finished");
            var userInput = Console.ReadLine();
            if(int.TryParse(userInput,out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if (selectedIngredient != null) 
                { 
                ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }
        }
        return ingredients;
    }
}

public interface IIngredientsRegister
{
    IEnumerable<Ingredient> All { get; }

    Ingredient GetById(int id);
}

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
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

    public Ingredient GetById(int id)
    {
        foreach (var ingredient in All)
        {
            if (ingredient.Id == id) return ingredient;
        }
        return null;
    }
}