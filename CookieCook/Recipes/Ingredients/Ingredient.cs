﻿namespace CookieCook.Recipes.Ingredients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string PreparationInstructions =>
            "Add to other Ingredients.";
        public override string ToString()
        {
            return $"{Id}. {Name}";
        }
    }
}
