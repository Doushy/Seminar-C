// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
System.Console.Write("Введите кол. строк: ");
int rows = int.Parse(Console.ReadLine()!)!;
System.Console.Write("Введите кол. столбцов: ");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
System.Console.WriteLine();

SortArray(array);
PrintArray(array);

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

void SortArray(int[,] inArray)
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
