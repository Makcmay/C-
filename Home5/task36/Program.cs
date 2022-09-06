// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] EnterRandomArray()
{
    Console.Write("Введите длину массива\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}

int CountArray(int[] array)
{
int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        {
            count+= array[i];
        }    
    }
    Console.WriteLine($"Сумма нечетных позиций = {count}");
    return count;
        
}

CountArray(EnterRandomArray()); 
