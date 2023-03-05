// 69

System.Console.Write("Введите число: ");
int userInput = int.Parse(Console.ReadLine()!)!;
System.Console.Write("Введите степень: ");
int userPow = int.Parse(Console.ReadLine()!)!;
Console.WriteLine(RecursePow(userInput, userPow));

int RecursePow(int inNum, int pow)
{
    if (pow == 1)
    {
        return inNum;
    }
    else
    {
        return inNum * RecursePow(inNum, pow - 1);
    }
}

