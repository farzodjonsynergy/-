using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения переменной А:");
        int A  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число для переменной B:");
        int B = Convert.ToInt32(Console.ReadLine());

        if (A != B)
        {
            int max = Math.Max(A, B);
            A = max;
            B = max;
        }
        else
        {
            A = 0;
            B = 0;

        }
        Console.WriteLine($"Новое значение А: {A}");
        Console.WriteLine($"Новое значение B: {B}");
    }
}

