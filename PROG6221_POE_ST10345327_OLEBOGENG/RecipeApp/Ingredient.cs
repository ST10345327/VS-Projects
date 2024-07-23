using System;

namespace RecipeApp
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; } // Added food group property

        public void EnterDetails()
        {
            Console.WriteLine("Enter ingredient name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter quantity:");
            while (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            Quantity = quantity;

            Console.WriteLine("Enter unit of measurement:");
            Unit = Console.ReadLine();

            Console.WriteLine("Enter number of calories:");
            while (!int.TryParse(Console.ReadLine(), out int calories) || calories <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            Calories = calories;

            Console.WriteLine("Enter food group:");
            FoodGroup = Console.ReadLine();
        }
    }
}
