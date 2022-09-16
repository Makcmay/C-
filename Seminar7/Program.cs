/Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArraySum(rows, columns);
PrintArray(array);

int[,] GetArraySum(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());

 array = GetArrayDouble(rows, columns,0,10);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));



int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}


Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());

 array = GetArrayDouble(rows, columns,0,10);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");


int GetSumDiag(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}



//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns = int.Parse(Console.ReadLine());

array = GetArrayDouble(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

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




//метод возвращающий индекс опорного элемента
int Partition(int[] array, int minIndex, int maxIndex)
{
    var pivot = minIndex - 1;//-1
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
           
            var tmp = array[pivot];
            array[pivot] = array[i];
            array[i] = tmp;
        }
    }

    pivot++;

    var temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;
    return pivot;
}

//быстрая сортировка
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    var pivotIndex = Partition(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

int[] GetArray(int size = 12, int minValue = -100, int maxValue = 100)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


var arr = GetArray();

Console.WriteLine("Mассив: {0}", string.Join(", ", arr));
var arraySort= QuickSort(arr,0, arr.Length - 1);
Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", arraySort));

Console.ReadLine();




// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

SomeMethod();

int[,] SomeMethod()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] mass = new int[m,n];

    for (int i = 0; i < mass.GetLength(0); i++)
    {

        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = i + j;
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
    return mass;
}

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
int[,] numbersPifagor()
{
Console.Write("Enter rows...");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter columns...");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] Pith = new int[rows, columns];

for (int i = 0; i < Pith.GetLength(0);i++)
{
    for (int j = 0; j < Pith.GetLength(1);j++)
    {
        Pith[i,j] = new Random().Next(10);
        Console.Write($"{Pith[i,j]} ");
    }
   Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < Pith.GetLength(0);i++)
{
    for (int j = 0; j < Pith.GetLength(1);j++)
    {
        if (i % 2==0 && j % 2 ==0)
        {
            Pith[i,j] *= Pith[i,j];
        }

        Console.Write($"{Pith[i,j]} ");
    }
   Console.WriteLine();
}
return Pith;  
}

numbersPifagor();

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

int[,] numbersSqu()
{
Console.Write("Enter rows...");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter columns...");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] Pith = new int[rows, columns];

for (int i = 0; i < Pith.GetLength(0);i++)
{
    for (int j = 0; j < Pith.GetLength(1);j++)
    {
        Pith[i,j] = new Random().Next(10);
        Console.Write($"{Pith[i,j]} ");
    }
   Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < Pith.GetLength(0);i++)
{
    for (int j = 0; j < Pith.GetLength(1);j++)
    {
        if (i == j)
        {
            Pith[i,j]++;
        }

        Console.Write($"{Pith[i,j]} ");
    }
   Console.WriteLine();
}
return Pith;  
}

numbersSqu();

// к дз 7
Start();

void Start()
{
    while (true)
    {
        Console.Clear();

        System.Console.WriteLine("47) Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.m = 3, n = 4");
        System.Console.WriteLine("50) Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве"
                                +"и возвращает значение этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("52) Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");

        int numTask = SetNumber();

        switch (numTask)
        {
            case 0: return; break;

            case 47:
            Console.Clear();
            GetDoubleArray();    
            break;

            // case 50:
            // Console.Clear();
            //     Console.WriteLine("Введите количество строк: ");
            //     int row = Convert.ToInt32(Console.ReadLine());

            //     Console.WriteLine("Введите колтчество столбцов: ");
            //     int column = Convert.ToInt32(Console.ReadLine());


            //     GetElement(GetRandomArray(m, n), )
            // break;
            // case 52:
            //     Console.Write("Введите количество строк: ");
            //     int m1 = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Введите колтчество столбцов: ");
            //     int n1 = Convert.ToInt32(Console.ReadLine());

            //     ArithmeticArrayRows(GetRandomArray(m1, n1));
            //     Console.WriteLine();

            // break;

        }    

    }

int SetNumber()
{
    System.Console.WriteLine();
    Console.Write("Введите номер задачи...");
    int number = int.Parse(Console.ReadLine());

    return number;
}
    int SetNumber()
    {
        Console.Write("Enter number of task...");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    int GetNumber();
    {
        Console.Clear();
        Console.Write("Введите позицию элемента массива через пробел: ");

        string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        
    }
}

Console.WriteLine();
Console.Write("Введите номер задачи: ");
int NumberTask = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (NumberTask == 47)
{
    GetDoubleArray();
}
else if (NumberTask == 50)
{
    PositionElement();
}
else if (NumberTask == 52)
{
    SASum();
}

// // //     Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // //     m = 3, n = 4.
// // //     0,5 7 -2 -0,2
// // //     1 -3,3 8 -9,9
// // //     8 7,8 -7,1 9

double[,] GetDoubleArray()
{
    Console.Write("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Введите количество строк массива:\t ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nВведите количество столбцов массива:\t ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    double[,] array = new double[m, n];

    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble();
            Console.Write($"{array[i, j]} " + "|");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
    return array;
}

// // // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // // и возвращает значение этого элемента или же указание, что такого элемента нет.

// // // Например, задан массив:
// // // 1 4 7 2
// // // 5 9 2 3
// // // 8 4 2 4

// // // 17 -> такого числа в массиве нет


void PositionElement()
{
    Console.WriteLine();
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
    Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine();

    int[,] array = new int[3, 4];

    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("Введите позицию элемента в строке: ");
    int PositionRow = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите позицию элемента в столбце: ");
    int PositionColumn = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Позиция элемента {PositionRow},{PositionColumn}");
    Console.WriteLine();

    if (PositionRow > array.GetLength(0) || PositionColumn > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента = {array[PositionRow - 1, PositionColumn - 1]}");
    }
    Console.WriteLine();
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void SASum()
{
    Console.Write("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    int[,] array = new int[m, n];
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    double SA = 0;

    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        SA = Math.Round((sum / array.GetLength(0)), 1);

        Console.Write($"{SA} " + "|");
    }
    Console.WriteLine();
    Console.WriteLine();
}