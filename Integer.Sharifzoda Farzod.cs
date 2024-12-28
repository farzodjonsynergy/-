// See https://aka.ms/new-console-template for more information
using System;

class Integer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите расстояние в сантиметрах");
        int L =
            Convert.ToInt32(Console.ReadLine());
        int meters = L / 100;

        Console.WriteLine("Количество полных метров: " + meters);
    }
}
