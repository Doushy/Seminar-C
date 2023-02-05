// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int inver = 0;
if (number > 0)
{
    inver = number - (number * 2);
    int count = 0;
    while (count <= number * 2)
    {
        Console.Write(inver + ", ");
        count++;
        inver++;
    }
}
if (number < 0)
{ inver = number - (number * 2); 
int count = 0;
while (count <= inver * 2)
{
    Console.Write(number + ", ");
    count++;
    number++;
}
}




