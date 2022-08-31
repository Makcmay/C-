using System;

namespace Home4

{
    class Program
    {
        static void Main(string[] agrs)
        {
            Task29();
        
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
            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            // 452 -> 11
            // 82 -> 10
            // 9012 -> 12

             static void Task27()
            {
                Console.Write("Введите число :");
                int num = int.Parse(Console.ReadLine());

                int result = 0;
                int length = (int)Math.Log10(num);

                for (int i = 0; i < length + 1; i++)
                {
                    result = result + num % 10;
                    num /= 10;
                }

                Console.WriteLine($"Сумма цифр в числе = {result}");
            }


             
            // 29/  Напишите программу, которая задаёт массив и выводит их на экран.
            // пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
            // надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , 
            // делать все в методе который возвращает массив
            // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            // 6, 1, 33 -> [6, 1, 33]

            int [] Task29()
            {
            Console.Write("Введите число элементов массива :");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение элементамассива :");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введите максиммальное значение элементамассива :");
            int max = int.Parse(Console.ReadLine());
            
            int[] arr = new int[index];
              
            for (int i = 0; i < index; i++)
            {
                arr[i] = new Random().Next(min, max+1); 
            }
            return arr;
            
            }
        }
        
    }

}
