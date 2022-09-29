// Программа, которая задаёт массив из 8 элементов и выводит их на экран.

void GetNumbersArr(int[] arr)
{
    Console.WriteLine("Введите целые числа - элементы массива!");

    for (int i = 0; i < arr.Length; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
}

int[] array = new int[8];

GetNumbersArr(array);
Console.WriteLine();
PrintArray(array);