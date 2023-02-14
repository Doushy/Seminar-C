Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}
else
{
    System.Console.WriteLine("Прямые не пересекаются (прямые параллельны)");
}







