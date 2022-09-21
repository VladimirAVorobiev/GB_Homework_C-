// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Числа равны", a);
}
else
{
    if (a > b)
    {
        Console.WriteLine("Большее число");
        Console.WriteLine(a);
        Console.WriteLine("Меньшее число");
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Большее число", b);
        Console.WriteLine(b);
        Console.WriteLine("Меньшее число", a);
        Console.WriteLine(a);
    }
}