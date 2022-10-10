// Программа, которая создает двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int GetNumberFromConsole(string text)
{
Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}

void FillRandomValueAndPrintArray(double[,] arr, int minValue, int maxValue)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=new Random().Next(minValue,maxValue+1)*new Random().NextDouble();
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}

double[,] CreationArray(int m, int n)
{
    return new double[m, n];
}

int m = GetNumberFromConsole("Введите количество строк в массиве");
int n = GetNumberFromConsole("Введите количество столбцов в массиве");
int minValue = GetNumberFromConsole("Введите минимальное значение элементов массива");
int mахValue = GetNumberFromConsole("Введите максимальное значение элементов массива");

double[,] array = CreationArray(m, n);
FillRandomValueAndPrintArray(array, minValue, mахValue);
