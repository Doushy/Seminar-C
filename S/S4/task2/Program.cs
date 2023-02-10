Console.Clear();
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Колличество = {NumberCounter(num)}");


int NumberCounter(int number)
{
    int count = 1;
    while (number > 10)
    {
        number = number / 10;
        count++;
    }
    return count;
}
