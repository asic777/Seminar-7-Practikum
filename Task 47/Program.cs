// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Task_47();

void Task_47()
{
    Console.WriteLine("Задача 47. Задание двумерного массива m*n, заполненного случайными вещественными числами.");

    Console.Write("Введите количество строк массива (m): ");
    int rowsArray = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов массива (n): ");
    int columnsArray = int.Parse(Console.ReadLine()!);

    double[,] array = FillArrayRandom(rowsArray, columnsArray, -99, 99);
    Console.WriteLine($"m = {rowsArray}, n = {columnsArray}");
    PrintArray(array);
}

double[,] FillArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    double[,] resultArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / 10;
            //resultArray[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
            //появляются значения "-0"
        }
    }

    return resultArray;
}

void PrintArray(double[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        Console.Write("[\t{0}", tempArray[i, 0]);
        for (int j = 1; j < tempArray.GetLength(1); j++)
        {
            Console.Write("\t{0}", tempArray[i, j]);
        }
        Console.WriteLine("\t]");
    }
}

