// Программа, которая позволяет задать значение N, выводит все натуральные числа в промежутке от N до 1,
// с помощью рекурсии.

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbersRecursionVoid(int startNumber, double lastNumber)
{
    if (lastNumber >= startNumber)
    {
        Console.Write(lastNumber + " ");
        WriteNumbersRecursionVoid(startNumber, lastNumber-1);
    }     
}

double number = Math.Floor(GetNumberFromConsole("Введите число N"));
WriteNumbersRecursionVoid(1, number);