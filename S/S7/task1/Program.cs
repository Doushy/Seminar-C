// See https://aka.ms/new-console-template for more information
int m = 3;
int n = 4;

Console.Clear();
Print2DArray(GenerateArray(m, n));

void Print2DArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            System.Console.Write(someArray[i, j]);
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
            res[i, j] = i + j;
        }
    }
    return res;
}