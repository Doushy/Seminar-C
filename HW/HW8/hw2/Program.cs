// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
System.Console.Write("Введите кол. строк: ");
int rows = int.Parse(Console.ReadLine()!)!;
System.Console.Write("Введите кол. столбцов: ");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, 1, 10);
//PrintArray(array);
System.Console.WriteLine();

SortArray(array);
PrintArray(array);
System.Console.WriteLine();
int line = MinArray(array);
Console.WriteLine($"Наименьшей сумма элементов: {line} страка");


int[,] GetArray(int m, int n, int minValue, int maxValue)      //Генератор Массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void SortArray(int[,] inArray)   //Для удобства(наглядности)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int c = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = c;
                }
            }
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int MinArray(int[,] inArray)      //Поиск мин строки
{
    int min = 0, line = 0, result = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            result += inArray[i, j];
        }
        if (result < min || i == 0)
        {
            min = result;
            line = i + 1;
        }
        result = 0;
    }
    return line;
}