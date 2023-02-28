System.Console.Write("Введите кол. строк: ");
int rows = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол. столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
PrintArray(NewArray(array));


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] NewArray(int[,] array)
{

    int[,] NewArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != 0)
            {
                NewArray[i, j] = array[i, j];
            }
            else
            {
                NewArray[i, j] = array[array.GetLength(0) - 1, j];
                NewArray[array.GetLength(0) - 1, j] = array[i, j];
            }
        }
    }
    return NewArray;
}