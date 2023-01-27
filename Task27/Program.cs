// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        var num = Convert.ToInt32(Console.ReadLine());
        var sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine($"Сумма чисел = {sum}");
    }
}