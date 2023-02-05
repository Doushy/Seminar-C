// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.WriteLine($"Введите число");
int num = int.Parse(Console.ReadLine());
int rem = num.ToString().Length;
double a1 = 0;

if (rem >= 3)
{
    a1 = Convert.ToInt32(num / Math.Pow(10, (rem-3))) % 10;
    System.Console.WriteLine($"{num} -> {a1}");
}
else
{
System.Console.WriteLine($"{num} -> третьей цифры нет");
}






