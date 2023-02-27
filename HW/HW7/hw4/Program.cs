// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
Console.Clear();

int[,] array = new int[m, n];

array = GenerateArray(m, n);
Print2DArray(array);
System.Console.WriteLine();
StringArraySum(array);

void Print2DArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            System.Console.Write(someArray[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateArray(int m, int n)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(0, 10);
        }
    }
    return res;
}

double StringArraySum(int[,] inArray)
{
    double sum = 0;
    double average = 0;
    System.Console.Write($"Среднее арифметическое каждого строчки: ");
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += inArray[i, j];
            average = sum / (inArray.GetLength(1));
            if ((i == (inArray.GetLength(0) - 1)) && (j == (inArray.GetLength(1) - 1)))
            {
                System.Console.Write(average + ". ");
            }
            else if (j == (inArray.GetLength(1) - 1))
            {
                System.Console.Write(average + "; ");
            }
        }
    }
    return average;
}
