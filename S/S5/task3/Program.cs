// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int[] array = GetArray(5, 0, 350);

Console.WriteLine("Введите число: ");
int Find = int.Parse(Console.ReadLine());

bool FindElement(int[] array,int value)
{
 for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value )
        {
            return true;
        }

    }
return false;
}
if (FindElement(array,Find))
{
    Console.WriteLine("Число найдено");
}
else
{
    Console.WriteLine("Число не найдено");
}