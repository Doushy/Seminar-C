// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
System.Console.Write("Ведите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
if ((quarter > 4) || (quarter < 1))
{
    System.Console.Write("Нет такой чертверти");
}
else if (quarter == 1)
{
    System.Console.Write("X>0;Y>0");
}
else if (quarter == 2)
{
    System.Console.Write("X<0;Y>0");
}
else if (quarter == 3)
{
    System.Console.Write("X<0;Y<0");
}
else
{
    System.Console.Write("X>0;Y<0");
}
