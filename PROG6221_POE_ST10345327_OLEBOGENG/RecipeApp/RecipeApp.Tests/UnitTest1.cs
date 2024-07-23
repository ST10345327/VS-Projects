using NUnit.Framework;
using RecipeApp;

namespace RecipeApp.Tests
{
    public class RecipeTests
    {
        [Test]
        public void CalculateTotalCalories_ShouldReturnCorrectTotal()
        {
            // Arrange
            var recipe = new Recipe();
            recipe.Ingredients = new System.Collections.Generic.List<Ingredient>
            {
                new Ingredient { Calories = 100 },
                new Ingredient { Calories = 200 },
                new Ingredient { Calories = 50 }
            };

            // Act
            var totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(350, totalCalories);
        }
    }
}
