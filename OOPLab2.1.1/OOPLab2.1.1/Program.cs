using System;
using System.Globalization;
namespace Lab2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Неправильні дані, повторіть ввід для x.");
            }
            Console.Write("Введіть y: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Неправильні дані, повторіть ввід для y.");
            }
            Console.Write("Введіть z: ");
            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Неправильні дані, повторіть ввід для z.");
            }
            double result = Math.Sin(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (z - (x / y)) + Math.Sin(Math.Cos(z));
            Console.WriteLine($"Результат обчислень: {result}");
        }
    }
}
