Console.Clear();
System.Console.Write("Введите кол. строк: ");
int rows = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол. столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
System.Console.WriteLine();

int[] rowAr = GetRowArray(array);
SortArray(rowAr);

System.Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

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

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(1) * inArray.GetLength(0)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
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

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            System.Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    System.Console.WriteLine($"{el} встречается {count}");
}