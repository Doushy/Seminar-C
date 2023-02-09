// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
System.Console.Write("Ведите НЕЧЁТНОЕ число. '123 или 12345 и т.д.' ");
double num = int.Parse(Console.ReadLine()!)!;
double a1, a2 = 1;
double length = num.ToString().Length;
double number = num;
if ((length % (2 * Math.Floor(length / 2))) == 1)
{
    int count = 0;
    bool test = true;
    while ((count < (num.ToString().Length - 2)) && (test = true))
    {
        a1 = Math.Round(num / (Math.Pow(10, (num.ToString().Length)) / 10), 0);
        a2 = num % 10;

        num = Math.Round((num % (Math.Pow(10, num.ToString().Length - 1)) / 10), 0);

        if (a1 == a2)
        { test = true; }
        else { test = false; }
        count = count + 2;
    }
    if (test == true)
    { System.Console.WriteLine($"{number} -> Да"); }
    else { System.Console.WriteLine($"{number} -> Нет"); }
}
else
{
    System.Console.WriteLine("Ввели ЧЕТНОКОЛЛИЧЕСТВЕННОЕ. Введите 3-n,5-n и т д");
}
