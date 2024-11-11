using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть коефіцієнт a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Помилка: неправильне значення для a.");
            return;
        }

        Console.Write("Введіть коефіцієнт b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Помилка: неправильне значення для b.");
            return;
        }

        Console.Write("Введіть коефіцієнт c: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Помилка: неправильне значення для c.");
            return;
        }

        double discriminant = b * b - 4 * a * c;
        Console.WriteLine($"Дискримінант: {discriminant:F3}");

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Корені рівняння: x1 = {x1:F3}, x2 = {x2:F3}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Єдиний корінь рівняння: x = {x:F3}");
        }
        else
        {
            Console.WriteLine("Коренів немає (дискримінант від'ємний).");
        }
    }
}