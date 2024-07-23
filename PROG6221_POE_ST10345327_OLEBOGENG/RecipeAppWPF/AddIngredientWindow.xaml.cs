using System.Windows;

namespace RecipeAppWPF
{
    public partial class AddIngredientWindow : Window
    {
        public Ingredient NewIngredient { get; private set; }

        public AddIngredientWindow()
        {
            InitializeComponent();
        }

        private void SaveIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            NewIngredient = new Ingredient
            {
                Name = IngredientNameTextBox.Text,
                Quantity = int.Parse(QuantityTextBox.Text),
                Unit = UnitTextBox.Text,
                Calories = int.Parse(CaloriesTextBox.Text),
                FoodGroup = FoodGroupTextBox.Text
            };
            DialogResult = true;
            Close();
        }
    }
}
