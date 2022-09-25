// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNumber()
{
    Console.WriteLine("Введите целое пятизначное число");
    return Convert.ToInt32(Console.ReadLine());
}

void Palindrom(int number)
{
    int dig1 = number % 10;
    // Console.WriteLine(dig1);
    int dig2 = number % 100 / 10;
    // Console.WriteLine(dig2);
    int dig4 = number % 10000 / 1000;
    // Console.WriteLine(dig4);
    int dig5 = number / 10000;
    // Console.WriteLine(dig5);

    if (dig1 == dig5 && dig2 == dig4) Console.WriteLine("Это число - палиндром");
    else Console.WriteLine("Это число - НЕ палиндром");

}

Palindrom(GetNumber());
