// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Task_52();

void Task_52()
{
    Console.WriteLine("Задача 52. Среднее арифметическое элементов в каждом стобце массива.");

    Console.Write("Введите количество строк массива (m): ");
    int rowsArray = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов массива (n): ");
    int columnsArray = int.Parse(Console.ReadLine()!);

    int[,] array = FillArrayRandom(rowsArray, columnsArray, 0, 9);
    PrintArray(array);

    AverageColumnsArray(array);
}

int[,] FillArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return resultArray;
}

void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        Console.Write("[{0}", tempArray[i, 0]);
        for (int j = 1; j < tempArray.GetLength(1); j++)
        {
            Console.Write(" {0}", tempArray[i, j]);
        }
        Console.WriteLine("]");
    }
}

void AverageColumnsArray(int[,] checkArray)
{
    double columnsAverage;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < checkArray.GetLength(1); j++)
    {
        columnsAverage = 0;
        for (int i = 0; i < checkArray.GetLength(0); i++)
        {
            columnsAverage += checkArray[i, j];
        }
        columnsAverage /= checkArray.GetLength(0);
        Console.Write($"{columnsAverage}; ");
    }
}