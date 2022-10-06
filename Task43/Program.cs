// Программа, которая находит точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void InputCoordinates(double[] arr)
{
    // Порядок ввода координат изменен согласно уранениям, так как это будет более удобно для пользователя
    Console.WriteLine("Введите последовательно значения k1, b1, k2 и b2 для прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2:");
    for (int i = 0; i < arr.Length; i++)
    {
                arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double[] array = new double[4];
InputCoordinates(array);

double coordinateX = (array[3]-array[1])/(array[0]-array[2]);
double coordinateY = array[0]*coordinateX + array[1];

Console.WriteLine($"Координаты точки пересечения прямых, заданных уравнениями ({coordinateX},{coordinateY})");
