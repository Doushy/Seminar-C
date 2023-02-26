// See https://aka.ms/new-console-template for more information

int m = 4;
int n = 4;
Console.Clear();

int[,] array = new int[m, n];

array = GenerateArray(m, n);
Print2DArray(array);
System.Console.WriteLine();
System.Console.WriteLine(DiagSum(array));

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

int DiagSum(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i == j))
            {
                sum += inArray[i, j];
            }
        }
    }
    return sum;
}