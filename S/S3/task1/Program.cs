// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
System.Console.Write("Ведите номер четверти: ");
long x1 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите номер четверти: ");
long x2 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите номер четверти: ");
long y1 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите номер четверти: ");
long y2 = long.Parse(Console.ReadLine()!)!;

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) + (y2 - y1));
System.Console.WriteLine(result);




