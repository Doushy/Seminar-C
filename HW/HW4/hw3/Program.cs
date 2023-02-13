﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 ,6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();

    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
    Console.WriteLine();
}

int length = Prompt("Длинна: ");
int min = Prompt("Min: ");
int max = Prompt("Max: ");

int[] array = GenerateArray(length, min, max);
PrintArray(array);