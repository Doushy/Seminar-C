// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите N:");
int UserN = int.Parse(Console.ReadLine()!)!;

NaturalNumbers(UserN);
Console.WriteLine();

void NaturalNumbers(int start, int n = 1)
{
    if (start >= n)
    {
        Console.Write($" {start}");
        if (start != n) Console.Write(","); else Console.WriteLine(".");
        NaturalNumbers(start - 1, n);
    }
}