// 67
System.Console.Write("Введите число: ");
int userInput = int.Parse(Console.ReadLine()!)!;
Console.WriteLine(SumDigits(userInput));

int SumDigits(int inNum)
{
    if ((inNum / 10) == 0)
    {
        return inNum;
    }
    else
    {
        return inNum % 10 + SumDigits(inNum / 10);
    }
}

