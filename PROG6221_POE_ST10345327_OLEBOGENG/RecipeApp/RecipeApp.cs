using System;
using System.Collections.Generic;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>();

            while (true)
            {
                Console.WriteLine("Enter 1 to add a recipe, 2 to display all recipes, or 3 to exit:");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Recipe recipe = new Recipe();
                        recipe.CalorieNotification += Message => Console.WriteLine(Message);
                        recipe.EnterDetails();
                        recipes.Add(recipe);
                        break;
                    case 2:
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("No recipes added yet.");
                        }
                        else
                        {
                            recipes.Sort((x, y) => string.Compare(x.Name, y.Name));
                            foreach (var r in recipes)
                            {
                                r.DisplayRecipe();
                            }
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
