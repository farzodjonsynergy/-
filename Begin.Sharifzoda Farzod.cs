// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны квадрата:");
        double a = 
        Convert.ToDouble(Console.ReadLine());

        double P = 4 * a;

        Console.WriteLine("Периметр квадрата: " + P);
    }
}

