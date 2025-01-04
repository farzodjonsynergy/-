// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите знак операции (+, -, *, /):");
        string sign = Console.ReadLine();

        if (sign == "+")
        {
            Console.WriteLine($"Результат: {operand1 + operand2}");
        }
        else if (sign == "-")
        {
            Console.WriteLine($"Результат: {operand1 - operand2}");
        }
        else if (sign == "*")
        {
            Console.WriteLine($"Результат: {operand1 * operand2}");
        }
        else if (sign == "/")
        {
            if (operand2 != 0)
            {
                Console.WriteLine($"Результат: {operand1 / operand2}");
            }
            else
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: неверный знак операции.");
        }

        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();
    }
}