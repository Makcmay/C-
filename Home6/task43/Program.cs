// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Enter K1=\t");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B1=\t");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter K2=\t");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B2=\t");
int b2 = Convert.ToInt32(Console.ReadLine());


if (k1 != k2)
    {
        double point1 = (b2 - b1) / (k1 - k2);
        double point2 = k1 * ((b2 - b1) / (k1 - k2)) + b1;

        Console.WriteLine($"Точка перечечения (x={point1};y={point2})");
    }
     else
    {
        Console.WriteLine("Точки пересечения нет, задайте K1 не равное K2 ");
     }