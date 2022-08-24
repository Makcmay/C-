// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Enter a number : ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);

if (number >= 100)
{
    System.Console.WriteLine($"Number= {number}; TherdN= {str[2]}");
}
else
{
    System.Console.WriteLine($"Третий цифры нет");
}

