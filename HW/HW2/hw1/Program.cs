// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.WriteLine($"Введите ТРЁХЗНАЧНОЕ число");
int num = int.Parse(Console.ReadLine());
int rem = num.ToString().Length;
int a1 = 0;
if (rem == 3)
{
    a1 = num / 10 % 10;
    System.Console.WriteLine($"{num} -> {a1}");
    }
else
{
System.Console.WriteLine($"Вы ввели {rem} значное число");
}






