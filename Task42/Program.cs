// программа, которое преобразует десятичное число в двоичное
// 45 -> 101101, 3 -> 11, 2 ->10

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

double newnumber = 0;
int ostatok = 0;
int i = 0;

while (number > 0)
{
    ostatok = number % 2;
    newnumber = newnumber + ostatok * Convert.ToInt32(Math.Pow(10, i));
    i++;
    number = number / 2;
}

Console.WriteLine($"Число в двоичной системе {newnumber}");