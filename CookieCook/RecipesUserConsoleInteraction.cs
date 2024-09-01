using CookieCook.Recipes;

public class RecipesUserConsoleInteraction : IRecipesUserInteraction
{
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
}