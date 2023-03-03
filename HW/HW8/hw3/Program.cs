// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] MatrixA = GetArray(2, 2);
System.Console.WriteLine("Первая матрица: ");
PrintArray(MatrixA);

int[,] MatrixB = GetArray(2, 3);
System.Console.WriteLine("Вторая матрица: ");
PrintArray(MatrixB);

int[,] MatrixС = MatrixMult(MatrixA, MatrixB);
System.Console.WriteLine("Произведение матриц: ");
PrintArray(MatrixС);

int[,] GetArray(int m, int n)      //Генератор Массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)      //Принт
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MatrixMult(int[,] MatrixA, int[,] MatrixB)      //Произведение матриц
{
    int rowsA = MatrixA.GetLength(0);
    int columnsB = MatrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (MatrixA.GetLength(1) == MatrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < MatrixA.GetLength(1); n++)
                {
                    result[i, j] += MatrixA[i, n] * MatrixB[n, j];
                }
            }
        }
    }
    return result;
}