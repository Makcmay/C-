// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

string SummOfNumbers()
{
    int[] array = new int[12];

    int sumPositive = 0;
    int sumNegative = 0;
    int result;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);

        result = (array[i] > 0) ? (sumPositive += array[i]) : (sumNegative += array[i]);
    }

    string output = $"You array: {String.Join(", ", array)}\nSumm of positive numbers of array is {sumPositive}\nSumm of positive numbers of array is {sumNegative}";;

    return output;
}

System.Console.WriteLine(SummOfNumbers());


// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] EnterRandomArray()
{
    Console.Write("Enter length of array...\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

void ChangeElements(int[] array)
{
    Console.WriteLine($"You array:       {String.Join(", ", array)}");
    
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = -1 * array[j];
    }

    Console.WriteLine($"You revert array: {String.Join(", ", array)}");
}


bool IsInArray(int[] array)
{
    Console.Write("Enter a number for find in array...\t");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You array: {String.Join(", ", array)}");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }

    return false;
}

ChangeElements(EnterRandomArray());

Console.WriteLine(IsInArray(EnterRandomArray()));

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] EnterRandomArray()
{
    Console.Write("Enter length of array...\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
    System.Console.WriteLine(String.Join(", ", array));
    return array;

}
int countElements(int[] array)
{
int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            sum++;
        }
    }
        System.Console.WriteLine(sum);
        return sum;
}
Console.Write(countElements(EnterRandomArray()));