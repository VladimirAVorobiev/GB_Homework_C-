// Программа, которая позволяет задать значение M и N, 
// и выводит сумму всех натуральных чисел от M до N.

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void WriteSumFromNToM(double numberM, double numberN)
{

    double startNumber = 0;
    double lastNumber = 0;
    // Определяем меньшее из двух введенных чисел
    if (numberM < numberN)
    {
        startNumber = Math.Floor(numberM);
        lastNumber = Math.Floor(numberN);
    }
    else
    {
        startNumber = Math.Floor(numberN);
        lastNumber = Math.Floor(numberM);
    }
    double sum = startNumber;
    while (startNumber < lastNumber)
    {
        startNumber++;
        sum = sum + startNumber;
    }
    Console.WriteLine($"Сумма всех натуральных чисел от M до N равна {sum}");
}

double m = GetNumberFromConsole("Введите число M");
double n = GetNumberFromConsole("Введите число N");


WriteSumFromNToM(m, n);