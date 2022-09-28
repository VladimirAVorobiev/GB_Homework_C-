// Программа, которая принимает на вход целое число и выдаёт сумму цифр в числе.

/*int GetNumber()

{
    Console.WriteLine("Введите целое число!");
    return Convert.ToInt32(Console.ReadLine());
}

void SumOfDigits(int number)
{
    int sumdigits = 0;
    int dig = 0;

    while (Math.Abs(number) > 0)
    {
        dig = number % 10;
        sumdigits = sumdigits + dig;
        number = number / 10;
    }
Console.WriteLine("Cумма цифр числа = " + sumdigits);
}

SumOfDigits(GetNumber());*/

// Попытался реализовать задачу с вещественным числом на входе.
// Приприобразовании вещественного числа, почему то добавляет к новому числу лишний 0

double GetNumber()

{
    Console.WriteLine("Введите число!");
    return Convert.ToDouble(Console.ReadLine());
}

int ConvertNumber(double number)
{
    int ostatok = 1;
    double newnumber = number;

    while (ostatok != 0)
    {
        ostatok = Convert.ToInt32(newnumber % 1);
        newnumber = newnumber * 10;
    }

    Console.WriteLine(newnumber);
    int newnumberint = Convert.ToInt32(newnumber);
    return newnumberint;
}

void SumOfDigits(int newnumber)
{
    int sumdigits = 0;
    int dig = 0;
    int newnumberint = Convert.ToInt32(newnumber);

    while (Math.Abs(newnumberint) > 0)
    {
        dig = Convert.ToInt32(newnumberint % 10);
        sumdigits = sumdigits + dig;
        newnumberint = newnumberint / 10;
    }
    Console.WriteLine("Cумма цифр числа = " + sumdigits);

}

int a = ConvertNumber(GetNumber());

SumOfDigits(a);