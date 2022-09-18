// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Task_50();

void Task_50()
{
    Console.WriteLine("Задача 50. Проверка существования элемента массива и возврат его значения.");

    Console.Write("Введите количество строк массива (m): ");
    int rowsArray = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов массива (n): ");
    int columnsArray = int.Parse(Console.ReadLine()!);

    int[,] array = FillArrayRandom(rowsArray, columnsArray, 0, 9);
    PrintArray(array);

    Console.Write("Введите номер строки элемента массива (m): ");
    int rowItem = int.Parse(Console.ReadLine()!);
    Console.Write("Введите номер столбца элемента массива (n): ");
    int columnItem = int.Parse(Console.ReadLine()!);
    
    CheckItemArray(array, rowItem, columnItem);
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

void CheckItemArray(int[,] checkArray, int checkRow, int checkColumn)
{
    if (checkRow >= 0 &&
        checkRow < checkArray.GetLength(0) &&
        checkColumn >= 0 &&
        checkColumn < checkArray.GetLength(1))
    {
        Console.WriteLine($"{checkRow}; {checkColumn} -> " + checkArray[checkRow, checkColumn]);
    }
    else
    {
        Console.WriteLine($"{checkRow}; {checkColumn} -> такого элемента в массиве нет");
    }

}