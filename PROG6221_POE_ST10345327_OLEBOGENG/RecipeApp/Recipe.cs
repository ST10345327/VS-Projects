using System;
using System.Collections.Generic;

namespace RecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<string> Steps { get; set; } = new List<string>();

        public delegate void CalorieNotificationHandler(string message);
        public event CalorieNotificationHandler CalorieNotification;

        public void EnterDetails()
        {
            Console.WriteLine("Enter recipe name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            while (!int.TryParse(Console.ReadLine(), out int numIngredients) || numIngredients <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Ingredient ingredient = new Ingredient();
                ingredient.EnterDetails();
                Ingredients.Add(ingredient);
            }

            Console.WriteLine("Enter the number of steps:");
            while (!int.TryParse(Console.ReadLine(), out int numSteps) || numSteps <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                Steps.Add(Console.ReadLine());
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit} - {ingredient.Calories} calories ({ingredient.FoodGroup})");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }

            int totalCalories = CalculateTotalCalories();
            Console.WriteLine($"Total calories: {totalCalories}");
            if (totalCalories > 300)
            {
                CalorieNotification?.Invoke("Warning: Total calories exceed 300!");
            }
            Console.WriteLine();
        }

        private int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
    }
}
