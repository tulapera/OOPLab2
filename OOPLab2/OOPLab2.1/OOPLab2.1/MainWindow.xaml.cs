using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace lab2_WPF
{
    public partial class MainWindow : Window
    {
        double x, y, z;
        public MainWindow()
        {
            InitializeComponent();
            xBox.PreviewTextInput += Box_PreviewTextInput;
            yBox.PreviewTextInput += Box_PreviewTextInput;
            zBox.PreviewTextInput += Box_PreviewTextInput;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            xBox.Focus();
            Box.Text = "Для запису дробового числа '.'";
        }
        private void Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0) || e.Text == "." || e.Text == "+" || e.Text == "-")
            {
                if (e.Text == "," && ((TextBox)sender).Text.IndexOf('.') == -1)
                {
                    e.Handled = true;
                    MessageBox.Show("Неправильний розділювач виправлено", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    ((TextBox)sender).Text += ".";
                    return;
                }
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Неправильні символи.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                e.Handled = true;
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;
            if (!double.TryParse(xBox.Text, out x))
                error = true;
            if (!double.TryParse(yBox.Text, out y))
                error = true;
            if (!double.TryParse(zBox.Text, out z))
                error = true;

            if (error)
            {
                MessageBox.Show("Неправильні дані, повторіть ввід.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                resultBox.Text = ((Math.Sin(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (z - (x / y)) + Math.Sin(Math.Cos(z)))).ToString();
            }
        }
    }
}
