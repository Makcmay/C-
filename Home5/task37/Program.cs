// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] EnterRandomArray()
{
    Console.Write("Введите длину массива\t");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}

int[] SumArray(int[] array)
{
int length = array.Length-1;
int sum = 0;
    for (int i = 0; i <= length-i; i++)
    {
        sum = array[i] * array[length-i];
        
        if (i == length-i) sum = array[i];
        Console.Write($"{sum}" + " ");
    }
return array;
}
SumArray(EnterRandomArray());


// int Prodact = 0;
// void ProdactNumber()
// {

//     if (arrSize % 2 == 0)
//     {
//         for (int index = 0; index < array.Length /2; index++)
//         {
//             Prodact = array[index] * array[array.Length - 1 - index];
//             Console.Write($"{Prodact}" + " ");
//         }
//     }
//     else 
    
//         for (int index = 0; index < array.Length /2; index++)
//         {
//             Prodact = array[index] * array[array.Length - 1 - index];
//             Console.Write($"{Prodact}" + " ");
//         }
//     Console.Write($"{array[array.Length/2]}");
// }
// ProdactNumber();