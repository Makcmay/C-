using System;

namespace Seminar2

{
    class Program
    {
        static void Main(string[] agrs)
        {
            MaxNumber4();
        }
        // нипишите программу которая выводит случайное число из отрезка [10, 99] 
        //и показывает наибольшую цифру
        static void MaxNumber()
        {
            int number1 = new Random().Next(10, 1000);

            int max = 0;

            int iterator = number1;
            while (iterator != 0)
            {
                int number2 = iterator % 10;
                if (number2 > max) max = number2;

                iterator /= 10;
            }
            System.Console.WriteLine($"Number {number1} Max {max}");
        }



        // нипишите программу которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру
        static void MaxNumber2()
        {
            int number = new Random().Next(10, 100);
            int number1 = number % 10;
            int number2 = number / 10;

            int max = number1;

            if (number1 < number2)
            {
                max = number2;
            }
            System.Console.WriteLine($"Number {number} Max {max}");
        }
        // напишите задачу которая выводит трехзначное число и удаляет вторую цифру
        static void MaxNumber3()
        {
            int number = new Random().Next(100, 1000);

            int result = ((number / 100) * 10)+(number % 10); // (number / 100) первая цифра числа (number % 10) последняя цифра

             System.Console.WriteLine($"Number= {number}; result= {result}");
        }
        // НАпишите программу которая на вход принимает два числа и будет выводить является ли второе число кратное первому
        // Если число 2 не кратно числу 1 то программа выволит остаток от деления
        static void MaxNumber4()
        {
            System.Console.Write("Enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine()); // int.Parse = Convert.ToInt32

            System.Console.Write("Enter second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                // int rem = 0;

                if (firstNumber % secondNumber == 0)
                {
                    System.Console.WriteLine("КРАТНО");
                }
                else
                {
                    // rem = (firstNumber % secondNumber); 
                    System.Console.WriteLine($"НЕ КРАТНО, остаток= {firstNumber % secondNumber}");
                }
            }
            else
            {
                System.Console.WriteLine($"Второе число больше первого");
            }

        }
        // Напишите программу которая принимает на вход два числа и про
       
    }
}