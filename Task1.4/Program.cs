﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введітьперше значення:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть друге значення:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть третє значення:");
        int number3 = int.Parse(Console.ReadLine());

        int maxNumber = Math.Max(Math.Max(number1, number2), number3);
        int minNumber = Math.Min(Math.Min(number1, number2), number3);

        Console.WriteLine($"Максимальне число: {maxNumber}");
        Console.WriteLine($"Мінімальне число: {minNumber}");
    }
}
