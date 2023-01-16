// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 == number1 * number1)
{
    Console.WriteLine($"число {number2} является квадратом числа {number1}");
}
else
{
    Console.WriteLine($"число {number2} не является квадратом числа {number1}");
}
