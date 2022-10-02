// Программа, которая задает массив вещественных чисел. 
// и находит разницу между максимальным и минимальным элементами массива.

//Так как в условии неопредены метод и интервал значений эл-тов массива,
//то задаем массив случайными вещественными значениями в диапазоне [-100, 100]

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = new Random().Next(-100, 100);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(" ");
}

void DiffMaxMin(double[] arr)
{
    double maximum = 0;
    double minimum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minimum)
        {
            minimum = arr[i];
        }
        if (arr[i] > maximum)
        {
    maximum = arr[i];
}
    }
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + (maximum-minimum));
}

Console.WriteLine("Введите целое число - количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Console.WriteLine(" ");
FillArray(array);
DiffMaxMin(array);