// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}
int value = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    value = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = value;
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}

Console.Write("Введите колличествл строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличествл столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();

int[,] matrix = new int[rows, columns];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
int[,] array = new int [rows, columns];

if (rows == columns)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        
            array[i, j] = matrix[j, i];
           

        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}

else Console.WriteLine("колличество строк не совпадает с колличество столбцов");
Console.WriteLine();
Console.WriteLine();