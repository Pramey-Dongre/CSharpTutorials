﻿namespace CookieCook.Recipes.Ingredients
{
    public abstract class Spices : Ingredient
    {
        public override string PreparationInstructions =>
            $"Take half a teaspoon. {base.PreparationInstructions}";
    }
}
