// Программа,которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int GetNumber()

{
    Console.WriteLine("Введите число, обозначающее день недели");
    return Convert.ToInt32(Console.ReadLine());
}

void HolydayDigit(int number)
{
    if (number > 5) Console.WriteLine("Ура! Выходной! Водка Пить - Земля Валяться!!!");
    else Console.WriteLine("Это будний день");

}
HolydayDigit(GetNumber());