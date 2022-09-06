// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] EnterRandomArray()
{
    Console.Write("Введите длину массива\t");
    int number = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[number];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}
double[] MinMaxArray(double[] array)
{
    int minPosition = 0;
    int maxPosition = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >  array[maxPosition]) 
        {
            maxPosition = i;
        }
        else
        {
            minPosition = i;
        }
    }
    Console.WriteLine($"Max элемент = {array[maxPosition]:F3}, Min элемет = {array[minPosition]:F3}");
    Console.WriteLine($"Разница между Max и Min элеметами = {array[maxPosition] - array[minPosition]:F3}");
    return array;
}            
MinMaxArray(EnterRandomArray());