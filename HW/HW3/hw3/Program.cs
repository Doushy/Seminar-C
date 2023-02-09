// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.Write("Ведите число ");
int num = int.Parse(Console.ReadLine()!)!;
int counter = 1;

while (counter < num)
{
    Console.Write(counter * counter * counter + ", ");
    counter++;
}
Console.WriteLine(counter * counter * counter + ".");