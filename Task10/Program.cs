// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetNumber()

{
    Console.WriteLine("Введите трехзначное целое число");
    return Convert.ToInt32(Console.ReadLine());
}

void SecondDigit(int number)
{
int second;
second = number % 100;
Console.WriteLine(second / 10);
}

SecondDigit(GetNumber());