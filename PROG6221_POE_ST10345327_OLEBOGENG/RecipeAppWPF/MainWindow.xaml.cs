using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeAppWPF
{
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes;

        public MainWindow()
        {
            InitializeComponent();
            recipes = new List<Recipe>();
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            var addRecipeWindow = new AddRecipeWindow();
            if (addRecipeWindow.ShowDialog() == true)
            {
                var newRecipe = addRecipeWindow.NewRecipe;
                newRecipe.CalorieNotification += message => MessageBox.Show(message);
                recipes.Add(newRecipe);
                DisplayRecipes();
            }
        }

        private void DisplayRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipes();
        }

        private void DisplayRecipes()
        {
            RecipesListView.ItemsSource = recipes.OrderBy(r => r.Name).ToList();
        }
    }
}
