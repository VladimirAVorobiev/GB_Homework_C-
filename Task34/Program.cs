// Программа, которая задает массив, заполненный случайными положительными трёхзначными числами,
// и показывает количество чётных чисел в массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(" ");
}

void CheckEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            sum++;
    }
    Console.WriteLine("Количество четных элементов массива равно " + sum);
}

Console.WriteLine("Введите целое число - количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine(" ");
FillArray(array);
CheckEvenNumbers(array);
