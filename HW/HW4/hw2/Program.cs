// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Exponentiate(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = Prompt("Число: ");
System.Console.WriteLine($"Сумма числа '{num}' = {Exponentiate(num)}");





