// https://metanit.com/sharp/tutorial/2.4.php

// Metanit (https://metanit.com/sharp/tutorial/2.4.php)
// C# и .NET | Массивы
// Массивы языка программирования C#, определение массивов, операции над ними, их перебор с помощью цикла for/foreach и использование

using System;
namespace Mynamespase
{
    class Myclass
    {
        public static void Main(string[] args)
        {
            // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
            /*void Number(string? data)
            {
                int number;
                while(true)
                {
                    if(int.TryParse(data, out number))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                        data = Console.ReadLine();
                    }
                }
                int num = (int)Math.Log10(number) + 1;
                Console.WriteLine($"Здесь будет киличество цифр {num}");
            }*/
            

            // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
            // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.



            Console.WriteLine("Введите число");
            // Number(Console.ReadLine());

            // Console.Write("Введите число: ");
            // int A = Convert.ToInt32(Console.ReadLine());
            // int sum = 0;

            // for(int i = 1; i <= A; i++)
            // {
            //     sum = sum + i;
            // }

            // Console.Write("Сумма = " +sum);

            /*Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
            количество цифр в числе.*/

            // Console.WriteLine("Enter number: ");
            // int number = int.Parse(Console.ReadLine());
            // int index = 0;
            //  while(number > 0)
            // {
            //     number = number/10;
            //     index++;
            // }
            // System.Console.WriteLine(index);

            // второй вариант.

            // Console.Write("Enter nymber...");

            // string num = Console.ReadLine();
            // int count = num.Length;
            // Console.WriteLine("Amount digit.." +count);

            /*Задача 28: Напишите программу, которая принимает на вход число N и
            выдаёт произведение чисел от 1 до N.*/



            /*void factorialdigit (string? data)
            
            
            {
                int num;
                while(true)
                {
                    if(int.TryParse(data, out num))
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("error to enter");
                        data = Console.ReadLine();
                    }
                }
                int result = 1;
                for (int i = 2;i<=num;i++)
                {
                    result*= i;
                }
                System.Console.WriteLine($"произведение чисел {result}");
            }
            Console.WriteLine("Enter number: ");
            factorialdigit(Console.ReadLine());
            ( работает только с маленькими числами)*/

            //  void factorialdigit (string? data)
            
            //  {
            //     ulong num;
            //     while(true)
            //     {
            //         if(ulong.TryParse(data, out num))
            //         {
            //             break;
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("error to enter");
            //             data = Console.ReadLine();
            //         }
            //     }
            //     ulong result = 1;
            //      for (ulong i = 2;i<=num;i++)
            //      {
            //         result*= i;
            //      }
            //     System.Console.WriteLine($"произведение чисел {result}");
            //  }

            // Console.WriteLine("Enter number: ");
            // factorialdigit(Console.ReadLine());

            // ( для двухначных чисел)


            ////Задача 30: Напишите программу, которая выводит массив из 8 
            //элементов, заполненный нулями и единицами в случайном порядке.//

            int[] array = new int[8];


            for(int i = 0; i < 8; i++)
            {
                array [i] = new Random().Next(0,2);
                System.Console.Write(array[i]+" ");
            }

//  Задачи от Кристины Большаковой
            // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

            // 456 -> 3
            // 78 -> 2
            // 89126 -> 5

            //Вариант 1

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine(count);


            //Вариант 2

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = (int)Math.Log10(number);
            Console.WriteLine(count+1);

            //Вариант 3

            static void numberLength() 
            {
                Console.Write("Введите число:");
                string number = Console.ReadLine();
                Console.WriteLine($"{number} -> {number.Length}");
            }

            // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

            // 4 -> 24
            // 5 -> 120

            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int P = 1;

            for (int i = 1; i <= N; i++)
            {
                P *= i;
            }
            Console.WriteLine("Произведение от 1 до N = " + P);

            // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

            //[1,0,1,1,0,1,0,0]

            int[]arr = new int[8];

            for (int i = 0; i < 8; i++)
            {
                arr[i] = new Random().Next(0,2);
            }

            Console.WriteLine($"[{String.Join(", ", arr)}]");


            // Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
            // 7 -> 28
            // 4 -> 10
            // 8 -> 36

            Console.WriteLine("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;

            for (int i = 1; i <= A; i++)
            {
                Sum = Sum + i;
            }
            Console.WriteLine("Сумма = "+Sum);

        }


    }
}
