// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите M:");
int UserStart = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите N:");
int UserLast = int.Parse(Console.ReadLine()!)!;
int sum = 0;
GapNumberSum(UserStart, UserLast);

void GapNumberSum(int start, int end)
{
    if (start > end)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (start++);
    GapNumberSum(start, end);
}

