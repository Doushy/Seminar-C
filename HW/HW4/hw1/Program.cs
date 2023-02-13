// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Exponentiate(int num, int exponent)
{
    int number = 1;
    for (int i = 0; i < exponent; i++)
    {
        number *= num;
    }
    return number;
}


int num = Prompt("Первое: ");
int exponent = Prompt("Второе: ");

if (exponent > 0)
{
    System.Console.WriteLine($"{num}^{exponent} -> {Exponentiate(num, exponent)}");
}
else
{
    System.Console.WriteLine("Показатель должен быть больше нуля");
}





