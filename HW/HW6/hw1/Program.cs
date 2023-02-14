// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] vars1;
int pars1;
System.Console.WriteLine("Введите числа через пробел");
vars1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out pars1) ? pars1 : 0).ToArray();
System.Console.Write($"[{String.Join(", ", vars1)}] -> {PositiveNumber(vars1)}");



int PositiveNumber(int[] array)
{
    int count = 0;

    foreach (int el in array)
    {
        if (el > 0)
        {
            count++;
        }
    }

    return count;
}



