// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] EnterRandomArray()
{
    Console.Write("Введите длинну массива\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}

int CountArray(int[] array)
{
int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            count++;
        }    
    }
    Console.WriteLine($"Количество четных чисел = {count}");
    return count;
        
}

CountArray(EnterRandomArray());
