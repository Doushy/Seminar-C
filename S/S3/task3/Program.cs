// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Clear();
System.Console.Write("Ведите число ");
int num = int.Parse(Console.ReadLine()!)!;
int counter = 1;

while (counter < num)
{
    Console.Write(counter * counter + ", ");
    counter++;
}
Console.WriteLine(counter * counter + ".");






