// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
System.Console.Write("Ведите число от 10 и более: ");
double num = int.Parse(Console.ReadLine()!)!;
double a1, a2 = 1;
double length = num.ToString().Length;
double number = num;

if (length >= 2)
{
    int count = 0;
    bool test = true;
    while ((count <= (num.ToString().Length)) && (test == true))
    {
        a1 = Math.Floor(num / (Math.Pow(10, ((num.ToString().Length)) - 1)));
        a2 = num % 10;
        //System.Console.WriteLine($"{a1} -> {a2}");   test
        num = Math.Floor((num % (Math.Pow(10, num.ToString().Length - 1)) / 10));
        //System.Console.WriteLine($"{num}");   test

        if (a1 == a2)
        { test = true; }
        else { test = false; }
        count = count + 1;
    }
    // System.Console.WriteLine($"{test} ");   test
    if (test == true)
    { System.Console.WriteLine($"{number} -> Да"); }
    else { System.Console.WriteLine($"{number} -> Нет"); }
}
else
{
    System.Console.WriteLine("Введите другое число.");
}

