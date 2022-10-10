// Программа, которая создает двумерный массив из целых чисел 
// и находит среднее арифметическое элементов в каждом столбце.

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

void GetColumnAverage(int[,] arr)
{
    double average = 0;
       for (int j = 0; j < arr.GetLength(1); j++)
    {
         int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        average = Convert.ToDouble(sum / arr.GetLength(0));   // Почему то не переводится в формат double
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {average}");            
    }
}

int m = GetNumberFromConsole("Введите количество строк в массиве");
int n = GetNumberFromConsole("Введите количество столбцов в массиве");
int minValue = GetNumberFromConsole("Введите минимальное значение элементов массива");
int mахValue = GetNumberFromConsole("Введите максимальное значение элементов массива");

int[,] array = CreationArray(m, n);
FillRandomValueAndPrintArray(array, minValue, mахValue);
GetColumnAverage(array);

