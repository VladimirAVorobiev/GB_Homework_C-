// Программа, которая задает одномерный массив, заполненный случайными числами. 
// и находит сумму элементов, стоящих на нечётных позициях. 

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Так как в условии неопреден интервал значений эл-тов массива,
        //то определяем его в диапазоне [-1000, 1000]
        arr[i] = new Random().Next(-1000, 1001);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(" ");
}

void SumEvenElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum=sum+ arr[i];
    }
    Console.WriteLine("Сумма четных элементов массива равна " + sum);
}

Console.WriteLine("Введите целое число - количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine(" ");
FillArray(array);
SumEvenElements(array);