System.Console.Write("Введите кол. строк: ");
int rows = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол. столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
System.Console.WriteLine();
if (rows == columns)
{
    array = NewArray(array);
    PrintArray(array);
}
else
{
    System.Console.WriteLine("Невозможно заменить строки на столбцы!");
}


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
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] NewArray(int[,] array)
{
    int[,] NewArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArray[j, i] = array[i, j];
        }
    }
    return NewArray;
}