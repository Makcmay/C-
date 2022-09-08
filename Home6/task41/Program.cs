// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите любое количество чисел через пробел: ");

string[] array = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(int.Parse(array[i]) > 0) count++;
}
Console.Write(count);