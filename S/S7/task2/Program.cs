// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
int m = 4;
int n = 4;

int[,] array = new int[m, n];
Console.Clear();
array = GenerateArray(m, n);
Print2DArray(array);
System.Console.WriteLine();
Kvadrat(array);
System.Console.WriteLine();
Print2DArray(array);

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

void Kvadrat(int[,] someArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                someArray[i, j] *= someArray[i, j];
            }
        }
    }
}