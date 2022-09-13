
Console.Clear();
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами");
System.Console.WriteLine();

double[,] GetDoubleArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());
    
    System.Console.WriteLine();
   
    var random = new Random();

    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10) + random.NextDouble();
            Console.Write($"{array[i, j]:F2} ");
        }
        Console.WriteLine();
    }
    return array;
}
GetDoubleArray();

int RandomRows()
{
    int rows = new Random().Next(2, 5);
    return rows;
}

int RandomColumns()
{
    int columns = new Random().Next(2, 5);
    return columns;
}

int[,] GetRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine();
Console.WriteLine();

 System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве"
                            +"и возвращает значение этого элемента или же указание, что такого элемента нет.");

static void GetElement(int[,] array)
{
    Console.Write("Введите индекс i: ");
    int indexRow = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите индекс j: ");
    int indexColumn = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Позиция элемента [{indexRow},{indexColumn}]");
    Console.WriteLine();

    if (indexRow > array.GetLength(0) || indexColumn > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента = {array[indexRow - 1, indexColumn - 1]}");
    }
    Console.WriteLine();
}
GetElement(GetRandomArray(RandomRows(), RandomColumns()));

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел."
                    +"Найдите среднее арифметическое элементов в каждом столбце");

static void ArithmeticArrayRows(int[,] array)
{
    double arithmeticMean = 0;

    Console.WriteLine($"\nСреднее арифметическое каждого столбца последнего массива:\n");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithmeticMean += array[i, j];
        }
        Console.Write($"{Math.Round(arithmeticMean / array.GetLength(0), 2)} ;");
        arithmeticMean = 0;
    }
}

ArithmeticArrayRows(GetRandomArray(RandomRows(), RandomColumns()));

