Console.Clear();
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine(GetMultiply(num));
int GetMultiply(int number)
{
    int result = 1;
    for (int count = 1; count <= number; count++)
    {
        result = result * count;
    }
    return result;
}