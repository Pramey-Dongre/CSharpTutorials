using System.Globalization;
const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

var ingredientsRegister = new IngredientsRegister();
var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(stringsRepository, ingredientsRegister),
    new RecipesUserConsoleInteraction(ingredientsRegister));
const string FileName = "recipes";
var fileMetaData = new FileMetaData(FileName, Format);

cookiesRecipesApp.Run(fileMetaData.ToPath());


