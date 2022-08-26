using System;

namespace Seminar3

{
    class Program
    {
        static void Main(string[] agrs)
        {
            MaxNumber();
        }
        static void MaxNumber()
        {
            // int number1 = new Random().Next(10, 1000);

            // int max = 0;

            // int iterator = number1;
            // while (iterator != 0)
            // {
            //     int number2 = iterator % 10;
            //     if (number2 > max) max = number2;

            //     iterator /= 10;
            // }
            // System.Console.WriteLine($"Number {number1} Max {max}");

            // AB = корень (xb-xa)^2 + (yb-ya)^2 (zb-za)^2
            static void MaxNumber1()
            {
            //  Напишите программу, которая по заданному
            // номеру четверти, показывает диапазон 
            // возможных координат точек в этой четверти 
            // (x и y)

            Console.WriteLine("Enter quater... ");
            int quaternumber = int.Parse(Console.ReadLine());
            if (quaternumber == 1)// делать чере swetch
            {
                Console.WriteLine("x > 0, y > 0");

            }
            else if (quaternumber == 2)
            {
                Console.WriteLine("x < 0, y > 0");

            }
            else if (quaternumber == 3)
            {
                Console.WriteLine("x < 0, y < 0");

            }
            else if (quaternumber == 4)
            {
                Console.WriteLine("x > 0, y < 0");

            }
            else
            {
                Console.WriteLine("Bug Error");
            }
            }
            static void MaxNumber2() 
            { 
            //Напишите программу, которая принимает на вход координаты двух точек и 
            //находит расстояние между ними в 2D пространстве.

            Console.WriteLine("Enter x1...");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1...");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2...");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2...");
            int y2 = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); // корень + возведение в степень

            // Console.WriteLine("длинна отрезка"+result);

            Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {result}");
            }
            static void MaxNumber3() 
            { 
            ////Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
            ////квадратов чисел от 1 до N.

            Console.WriteLine("Enter number...");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Таблица квадратов");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            }
        }
    }

}