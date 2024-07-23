using System.Collections.Generic;
using System.Windows;

namespace RecipeAppWPF
{
    public partial class AddRecipeWindow : Window
    {
        public Recipe NewRecipe { get; private set; }
        private List<Ingredient> ingredients;
        private List<string> steps;

        public AddRecipeWindow()
        {
            InitializeComponent();
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            var addIngredientWindow = new AddIngredientWindow();
            if (addIngredientWindow.ShowDialog() == true)
            {
                ingredients.Add(addIngredientWindow.NewIngredient);
                IngredientsListView.ItemsSource = null;
                IngredientsListView.ItemsSource = ingredients;
            }
        }

        private void AddStepButton_Click(object sender, RoutedEventArgs e)
        {
            var addStepWindow = new AddStepWindow();
            if (addStepWindow.ShowDialog() == true)
            {
                steps.Add(addStepWindow.Step);
                // Optionally update UI to show steps
            }
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            NewRecipe = new Recipe
            {
                Name = RecipeNameTextBox.Text,
                Ingredients = ingredients,
                Steps = steps
            };
            DialogResult = true;
            Close();
        }
    }
}
