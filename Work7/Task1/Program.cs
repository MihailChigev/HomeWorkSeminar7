// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8 7, 8 -7,1   9

Console.Clear();


void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(+array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] CreateRandomArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("введите значение m: ");
int n = EnterNumber("введите значение n: ");
double[,] matrix = CreateRandomArray(m, n);
ShowArray(matrix);
