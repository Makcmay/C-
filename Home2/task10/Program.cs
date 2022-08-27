// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.Write("Enter a three-digit number : ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = new Random().Next(100, 1000);

int result = ((number / 10) - (number / 100) * 10); 

System.Console.WriteLine($"Number= {number}; result= {result}");