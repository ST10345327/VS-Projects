using System.Windows;

namespace RecipeAppWPF
{
    public partial class AddStepWindow : Window
    {
        public string Step { get; private set; }

        public AddStepWindow()
        {
            InitializeComponent();
        }

        private void SaveStepButton_Click(object sender, RoutedEventArgs e)
        {
            Step = StepTextBox.Text;
            DialogResult = true;
            Close();
        }
    }
}
