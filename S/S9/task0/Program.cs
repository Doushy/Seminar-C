//63
Console.Write("Введите N:");
int UserN = int.Parse(Console.ReadLine()!)!;

NaturalNumbers(UserN);
Console.WriteLine();

void NaturalNumbers(int n, int start = 1)
{
    if (start <= n)
    {
        Console.Write($" {start}");
        if (start != n) Console.Write(","); else Console.WriteLine(".");
        NaturalNumbers(n, start + 1);
    }

}