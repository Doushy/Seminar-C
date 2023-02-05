// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
System.Console.WriteLine($"Введите цифру от 1 - 7");
int num = int.Parse(Console.ReadLine());
if ((num == 6) || (num == 7))
{
    System.Console.WriteLine($"{num} -> Да");
}
else
{
    System.Console.WriteLine($"{num} -> Нет");
}












