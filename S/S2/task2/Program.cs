// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно 

Console.Clear();
System.Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int rem = num1 % num2;
if( rem == 0)
{
    System.Console.WriteLine($"{num1}, {num2} -> кратно");    
}
else
{
    System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {rem} ");
}
