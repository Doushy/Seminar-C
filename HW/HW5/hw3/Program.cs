// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] array = GetArray(4);
System.Console.Write($"[{String.Join(", ", array)} ] -> ");
System.Console.Write(SearchDifference(array));

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        // res[i] = Math.Round(new Random().NextDouble(), 3);
        res[i] = Convert.ToDouble(new Random().Next(0, 1000) / 10.00);
    }
    return res;
}

double SearchDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = Math.Round(max - min, 2);
    return result;
}