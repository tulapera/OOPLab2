using System;
using System.Windows;

namespace QuadraticEquationSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) && double.TryParse(bTextBox.Text, out double b) && double.TryParse(cTextBox.Text, out double c))
            {
                double discriminant = b * b - 4 * a * c;
                resultTextBlock.Text = $"Дискримінант: {discriminant:F3}\n";

                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    resultTextBlock.Text += $"Корені рівняння: x1 = {x1:F3}, x2 = {x2:F3}";
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    resultTextBlock.Text += $"Єдиний корінь рівняння: x = {x:F3}";
                }
                else
                {
                    resultTextBlock.Text += "Коренів немає (дискримінант від'ємний).";
                }
            }
            else
            {
                resultTextBlock.Text = "Помилка: неправильне значення для коефіцієнтів.";
            }
        }
    }
}
