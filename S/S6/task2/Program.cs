// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int askNumber(string msg)
{
    System.Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int num = askNumber("число: ");

string Binary(int num)
{
    int notation = 2; //система счисления
    string sum = String.Empty;
    while (num > 0)
    {
        sum = num % notation + sum;
        num /= notation;
    }
    return sum;
}

System.Console.WriteLine(Binary(num));

