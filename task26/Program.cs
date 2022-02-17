// Возведите число А в натуральную степень B, используя цикл.

Console.WriteLine("Возвести число А в натуральную степень В");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");