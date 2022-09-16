

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

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
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

System.Console.WriteLine("Задача 54: Задайте двумерный массив." 
+"Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

int[,] CourseArray(int[,] array)
{
    System.Console.WriteLine("Упорядоченный массив :");

    int col = array.GetLength(0);
    int rol = array.GetLength(1);

    for (int i = 0; i < col; i++)
    {

        for (int j = 0; j < rol; j++)
        {
            for (int k = 0; k < rol; k++)
            {
                if (array[i, j] > array[i, k])
                {
                    var temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
    return array;

}

PrintArray(CourseArray(GetRandomArray(4, 4)));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив."
+"Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

void RowsSumCount(int[,] array)
{

    int col = array.GetLength(0);
    int rol = array.GetLength(1);

    int minRowSum = int.MaxValue;
    int indexRow = 0;

    for (int i = 0; i < col; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < rol; j++)
        {
             rowSum += array[i, j];

                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexRow = i;
                }

        }

    }
System.Console.WriteLine($"Строка = {indexRow + 1}");
}
RowsSumCount(GetRandomArray(4, 4));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
System.Console.WriteLine();
System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу," 
                        +"которая будет находить произведение двух матриц.");

void MathArray()
{
    int[,] matrix1 = GetRandomArray(2, 2);
    System.Console.WriteLine("Первая матрица");

    int[,] matrix2 = GetRandomArray(2, 2);
    System.Console.WriteLine("Вторая матрица");

    int[,] matrix3 = new int[2, 2];

    int col = matrix3.GetLength(0);
    int rol = matrix3.GetLength(1);


    for (int i = 0; i < col; i++)
    {

        for (int j = 0; j < rol; j++)
        {

           matrix3[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1]*matrix2[1, j];

            Console.Write($" {matrix3[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Произведение матриц");
}

MathArray();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
System.Console.WriteLine();
System.Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел."
+"Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента."
+"Массив размером 2 x 2 x 2");

int [,,] TripleArray(int rows, int columns, int deep)
{
int[] arr = new int[Convert.ToInt32(Math.Pow(rows, 3))];

Random rnd = new Random((new Random()).Next());

for (int i = 0; i < arr.GetLength(0); i++)
{
    int j = rnd.Next(10, 100);                      // тут получаем случайное значение
    while (arr.Contains(j)) j = rnd.Next(10, 100); // тут проверяем
    arr[i] = j;                                    // тут сохраняем
}

foreach (int i in arr) Console.Write(i.ToString() + " "); // вывод первого массива(можно убрать)
Console.WriteLine();
Console.WriteLine();

 int[,,] array = new int[rows, columns, deep];

 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[i, j, k] = arr[k + j * deep + i * columns * deep];
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            
            System.Console.WriteLine();
        }   
    }
    return array;
}
TripleArray(2,2,2);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
System.Console.WriteLine();
System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4"
                        +"Например, на выходе получается вот такой массив:");
System.Console.WriteLine();

int len = 4;
int[,] array = new int[len, len];
FillArraySpiral(array, len);
PrintArraySpiral(array);



void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArraySpiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
