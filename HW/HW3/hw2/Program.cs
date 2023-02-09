Console.Clear();
System.Console.Write("Ведите x1: ");
long x1 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите y1: ");
long x2 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите x2: ");
long y1 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите y2: ");
long y2 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите x3: ");
long z1 = long.Parse(Console.ReadLine()!)!;
System.Console.Write("Ведите y3: ");
long z2 = long.Parse(Console.ReadLine()!)!;

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
System.Console.WriteLine(result);
