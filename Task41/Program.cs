// Программа, которая позволяет пользователю ввести с клавиатуры M чисел, 
// и производит подсчет, сколько чисел больше 0 ввёл пользователь.


void FillArrayUsersNumbers(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void CheckAndPrint(double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) { count++; }
    }
    Console.WriteLine($"Вы ввели {count} положительных числа");
}

Console.WriteLine("Введите целое число - количество чисел, которые вы планируете вносить");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

FillArrayUsersNumbers(array);
CheckAndPrint(array);