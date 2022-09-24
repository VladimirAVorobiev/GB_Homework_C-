// Программа,которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int GetNumber()

{
    Console.WriteLine("Введите целое число");
    return Convert.ToInt32(Console.ReadLine());
}

void ThirdDigit(int number)
{
int third;
    if (number < 100) Console.WriteLine("Число не иммет третьей цифры");
else
{
third = number % 1000;
Console.WriteLine("Третья цифра числа = " + third / 100);
}

}
ThirdDigit(GetNumber());