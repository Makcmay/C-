using System;

namespace Home4

{
    class Program
    {
        static void Main(string[] agrs)
        {
            Task25();
        
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            // 3, 5 -> 243 (3⁵)
            // 2, 4 -> 16

            static void Task25()
            {
                Console.Write("Введите число A :");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите число B :");
                int num2 = int.Parse(Console.ReadLine());

                double result = Math.Pow(num1, num2);
            
                Console.WriteLine($"Число {num1} в степени {num2} = {result}");
            }
        }
        
    }

}

