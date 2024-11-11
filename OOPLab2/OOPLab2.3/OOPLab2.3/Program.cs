using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть значення n та k:");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Виберіть яке значення порахувати (1, 2, або 3):");
        int choice = int.Parse(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = Calc1(n, k);
                break;
            case 2:
                result = Calc2(n, k);
                break;
            case 3:
                result = Calc3(n, k);
                break;
            default:
                Console.WriteLine("Неправильний варіант вибору. Потрібно обрати серед 1, 2, або 3.");
                return;
        }
        Console.WriteLine($"Результат вибраного значення: {result}");
    }

    static double Calc1(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / (n + i);
        }
        return sum;
    }

    static double Calc2(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / (n * n + i * i);
        }
        return sum;
    }

    static double Calc3(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / (n + i - 1) / (n + i);
        }
        return sum;
    }
}
