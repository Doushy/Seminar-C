int[] vars1, vars2;
int pars1, pars2;
System.Console.WriteLine("Введите числа для x1 y1 z1 через пробел");
vars1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out pars1) ? pars1 : 0).ToArray();
System.Console.WriteLine("Введите числа для x2 y2 z2 через пробел");
vars2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out pars2) ? pars2 : 0).ToArray();

double result = Math.Round(Math.Sqrt((vars2[0] - vars1[0]) * (vars2[0] - vars1[0]) + (vars2[1] - vars1[1]) * (vars2[1] - vars1[1]) + (vars2[2] - vars1[2]) * (vars2[2] - vars1[2])), 2);

System.Console.WriteLine(result);
