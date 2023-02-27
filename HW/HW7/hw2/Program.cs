// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7]->по такому индексу нет элемента.

System.Console.Write("Введите index строки: ");
int rows = int.Parse(Console.ReadLine()!)!;
System.Console.Write("Введите index столбца: ");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
System.Console.WriteLine();
PrintArrayElements(array, rows, columns);

int[,] GetArray(int m, int n, int minValue, int maxValue)
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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((j == columns) && (i == rows))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            System.Console.Write($"{inArray[i, j]} ");
            Console.ResetColor();
        }
        System.Console.WriteLine();
    }
}

void PrintArrayElements(int[,] inArray, int rows, int columns)
{
    if ((rows < inArray.GetLength(0)) && (columns < inArray.GetLength(1)))
    {
        System.Console.Write($"[{rows},{columns}] -> {inArray[rows, columns]} ");
    }
    else
    {
        System.Console.WriteLine($"[{rows},{columns}] -> по такому индексу нет элемента");
    }
}



