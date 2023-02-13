// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

int askNumber(string msg)
{
    System.Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int num1 = askNumber("Первое: ");
int num2 = askNumber("Второе: ");
int num3 = askNumber("Третье: ");

if (num2 + num3 > num1 && num1 + num3 > num2 && num2 + num3 > num1)
{
    System.Console.WriteLine("Треугольник может существовать");
}
else
{
    System.Console.WriteLine("Треугольник не может существовать");
}