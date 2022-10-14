// Программа, которая задает прямоугольный двумерный массив
// и находит строку с наименьшей суммой элементов.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillRandomValueAndPrintArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreationArray(int m, int n)
{
    return new int[m, n];
}

void SearchRowWithSumMin(int[,] arr)
{
    int sumMin = 2000000000;
    int rowMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i + 1} = {sum}"); // Используем для упрощения контроля
        if (sum < sumMin)
        {
            sumMin = sum;
            rowMin = i;
        }
    }
    Console.WriteLine($"Строка {rowMin + 1} имеет наименьшую сумму элементов");
}

int m = GetNumberFromConsole("Введите количество строк в массиве");
int n = GetNumberFromConsole("Введите количество столбцов в массиве");
int minValue = GetNumberFromConsole("Введите минимальное значение элементов массива");
int mахValue = GetNumberFromConsole("Введите максимальное значение элементов массива");

int[,] array = CreationArray(m, n);
FillRandomValueAndPrintArray(array, minValue, mахValue);
SearchRowWithSumMin(array);
