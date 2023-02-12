Console.Clear();

int[] arr = new int[8];
int[] arr2 = new int[8];
int[] sumArr = new int[8];
RandomArray(arr);
RandomArray(arr2);
PrintArray(arr);
PrintArray(arr2);
System.Console.WriteLine("сумма");
SumArr(arr, arr2);
PrintArray(sumArr);


void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}

void RandomArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void SumArr(int[] array1, int[] array2)
{
    for (int i = 0; i < 8; i++)
    {
        sumArr[i] = array1[i] + array2[i];
    }

}