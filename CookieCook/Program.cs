using CookieCook.Recipes;

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesUserConsoleInteraction(new IngredientsRegister()));
cookiesRecipesApp.Run("recipes.txt");
public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;
    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);
        _recipesUserInteraction.PromptToCreateRecipe();
        //var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();
        //if (ingredients.Count > 0)
        //{
        //    var recipe = new Recipe(ingredients);
        //    allRecipes.Add(recipe);
        //    _recipesRepository.Write(filePath, allRecipes);
        //    _recipesUserInteraction.ShowMessage("Recipe added to the Console");
        //    _recipesUserInteraction.ShowMessage(recipe);
        //}
        //else
        //{
        //    _recipesUserInteraction.ShowMessage(
        //        "No ingredients have beeen selected.Recipe will not be saved ");

        //}
        _recipesUserInteraction.Exit();
    }
}

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
}