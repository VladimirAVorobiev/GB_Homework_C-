// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int maximal = a;

if (b > maximal) maximal = b;
if (c > maximal) maximal = c;

Console.Write("Максимальное число = ");
Console.WriteLine(maximal);