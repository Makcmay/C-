// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Введите число от 1 до 7 : ");
int weekNumber = Convert.ToInt32(Console.ReadLine());

switch (weekNumber)
{
    case 1: System.Console.WriteLine("Понедельник"); break;
    case 2: System.Console.WriteLine("Вторник"); break;
    case 3: System.Console.WriteLine("Среда"); break;
    case 4: System.Console.WriteLine("Четверг"); break;
    case 5: System.Console.WriteLine("Пятница"); break;
    case 6: System.Console.WriteLine("Суббота"); break;
    case 7: System.Console.WriteLine("Воскресенье"); break;
    default: System.Console.WriteLine("Ошибка"); break;
}
