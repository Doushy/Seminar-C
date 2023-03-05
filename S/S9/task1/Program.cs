//65

Console.Write("Введите :");
string first = Console.ReadLine()!;
Console.Write("Введите :");
string last = Console.ReadLine()!;

Console.WriteLine(NaturalNumbersString(first, last));
Console.WriteLine();

string NaturalNumbersString(string start, string end)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + ", " + NaturalNumbersString(Convert.ToString(int.Parse(start) + 1), end);
    }
}