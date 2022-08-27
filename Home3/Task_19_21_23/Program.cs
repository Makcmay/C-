using System;

namespace Seminar3

{
    class Program
    {
        static void Main(string[] agrs)
        {
            Task23();
        }
        static void Task19()
        {
            // Задача 19

            // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
            //является ли оно палиндромом.
            // 14212 -> нет
            // 12821 -> да
            // 23432 -> да

            Console.WriteLine("Введите пятизначное число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            
            if (str.Length > 4 && str.Length <= 5)
            {
                if (str[0] == str[4] && str[1] == str[3])
                {
                System.Console.WriteLine($"Number= {number}; Полиндромом");
                }
                else
                {
                System.Console.WriteLine($"Number= {number}; не является Полиндромом");
                }
            }
            else
            {
                System.Console.WriteLine($"Number= {number}; не является Пятизначным");
            }
        }
        static void Task21()
        {
            // Задача 21

            // Напишите программу, которая принимает на вход координаты двух точек 
            // и находит расстояние между ними в 3D пространстве.
            // A (3,6,8); B (2,1,-7), -> 15.84
            // A (7,-5, 0); B (1,-1,9) -> 11.53

           
            Console.Write("Enter x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter z1 = ");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter z2 = ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 

            Console.WriteLine($"Точка A ({x1},{y1},{z1}); Точка B ({x2},{y2},{z2}) -> Расстояние AB = {result:f3}");
        }

        static void Task23()
        {
            // Задача 23

            // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            // 3 -> 1, 8, 27
            // 5 -> 1, 8, 27, 64, 125

            Console.Write("Enter number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Таблица кубов числа {number}");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            
        }
        
    }

}