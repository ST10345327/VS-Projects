using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeAppWPF
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        // Event for calorie notification
        public event Action<string> CalorieNotification;

        // Constructor
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        // Property to calculate total calories
        public int TotalCalories => Ingredients.Sum(i => i.Calories);

        // Method to check if the recipe exceeds a calorie limit
        public void CheckCalorieLimit(int limit)
        {
            if (TotalCalories > limit)
            {
                CalorieNotification?.Invoke($"Warning: The recipe '{Name}' exceeds the calorie limit of {limit} calories.");
            }
        }
    }
}
