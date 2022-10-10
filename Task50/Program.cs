// Программу, которая рандомно создает массив n х m. 
// Позволяет пользователю ввести значения n и m для поиска элемента массива.
// Возвращает значение этого элемента по ввеным значениям для поиска или же указание, что такого элемента нет.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillRandomValueAndPrintArray(double[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1) * new Random().NextDouble();
            Console.Write(arr[i, j] + " "); // Используем эту строку для контроля корректности результатов
        }
        Console.WriteLine(); // Используем эту строку для контроля корректности результатов
    }
}

double[,] CreationArray(int m, int n)
{
    return new double[m, n];
}

void SearchElementOfArray(double[,] arr, int xelement, int yelement)
{
    if (xelement > arr.GetLength(1) || yelement > arr.GetLength(0))
    { Console.WriteLine("Найти элеменет невозможно, так как вы ввели значения индексов элемента выходящие за объявленные размеры массива"); }
    else Console.WriteLine($"Значение найденного элемента равно {arr[yelement - 1, xelement - 1]}");
}

int m = GetNumberFromConsole("Введите количество строк в массиве");
int n = GetNumberFromConsole("Введите количество столбцов в массиве");
int minValue = GetNumberFromConsole("Введите минимальное значение элементов массива");
int mахValue = GetNumberFromConsole("Введите максимальное значение элементов массива");
int x = GetNumberFromConsole("Введите номер столбца искомого элемента массива");
int y = GetNumberFromConsole("Введите номер строки искомого элемента массива");


double[,] array = CreationArray(m, n);
FillRandomValueAndPrintArray(array, minValue, mахValue);
Console.WriteLine();
SearchElementOfArray(array, x, y);

