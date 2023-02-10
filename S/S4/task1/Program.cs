
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine($"сумма = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}