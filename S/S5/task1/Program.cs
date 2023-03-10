// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 





int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    if (el > 0)
    {
        positiveSum += el;
    }
    else
    {
        negativeSum += el;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательный чисел = {negativeSum}");