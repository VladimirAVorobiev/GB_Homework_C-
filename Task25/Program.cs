// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B с помощью цикла


double GetNumber()
{
    Console.WriteLine("Введите число A");
    return Convert.ToDouble(Console.ReadLine());
}

int GetStepen()
{
    Console.WriteLine("Введите целое число N - показатель степени");
    return Convert.ToInt32(Console.ReadLine());
}

void PowOfNumber(double number, int stepen)
{
    double numberinstepen = 1;

    for (int i = 1; i <= stepen; i++)

    {
        numberinstepen = numberinstepen * number;
    }

    Console.WriteLine("Число A в степени N = " + numberinstepen);

}

double number = GetNumber();
int stepen = GetStepen();
PowOfNumber(number, stepen);