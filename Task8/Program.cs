// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

int even_number = 2;

if (N <= 0)
{
Console.WriteLine("Введенное число не является положительным");    
}
else
{
    while (even_number <= N)
    {
        Console.WriteLine(even_number);
        even_number += 2;
    }
}