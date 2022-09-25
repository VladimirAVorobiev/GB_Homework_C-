// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int GetNumber()
{
    Console.WriteLine("Введите целое число");
    return Convert.ToInt32(Console.ReadLine());
}

void RowOfCubes(int number)
{
    int count = 1;
Console.WriteLine("Ряд кубов чисел от 1 до введенного числа");
    while (count <= number)
    {
        Console.Write(" " + Math.Pow((count),3));
        count ++;
    }
}

RowOfCubes(GetNumber());
