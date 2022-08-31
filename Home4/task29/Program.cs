using System;

namespace Home4

{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine($"[{String.Join(", ", Task29())}]");
             
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
            int res = 0; 
            for (int i = 0; i < index; i++)
            {
                arr[i] = new Random().Next(min, max+1); 
                res = res + arr[i];
            }
            return arr;

            }
        }
        
    }

}
