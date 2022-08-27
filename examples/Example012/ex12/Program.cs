//ВИД 1 не принимают аргументов и ничего не возвращают

void Method1()
{
    System.Console.WriteLine("Автор...");
}
// Method1(); // вызов метода

//ВИД 2 принимают аргументы но не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2(msg: "Text");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21(msg: "Text", count: 4); // если аргумент именнован можно поменять местами
// Method21(count: 4, msg: "New Text");

// ВИД 3 могут возвращать но не принимаю аргументы - генирация случайных данных

int Method3() // Происходит работа метода, определяет год
{
    return DateTime.Now.Year;
}
int year = Method3(); // результат работы метода присваеватся как значение к переменной
// System.Console.WriteLine(year); // вывод значения

// ВИД 4 принимаю данные и возвращают для дальнейшей работы

string Method4(int count, string text) // правой кнопкой можно переименовать символ
{

    string result = String.Empty; // результат изначально пустая строка можно ""; так

    for (int i = 0; i < count; i++) // вместо while // ЦИКЛ FOR for (int i = 0, i<10, i++) 
    // счетчик, все собирает в себе, не нужно отддельно вводить данные
    {
        result = result + text;
    }
    // int i = 0;
    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;
    return result;
}
string res = Method4(10, "z");
// System.Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        // System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
   // Console.WriteLine(); // разрыв строки
}

// дан текст, нужно заменить пробелы черточками, маленькие "к" на большие "К", "С" на "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int lenght = text.Length; // опредиляем число символов в строке

    for (int i = 0; i < lenght; i++)
    {
        if (text[i] ==  oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// System.Console.WriteLine(text);
// System.Console.WriteLine();

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText); // получили текс с заменой пробелов
// System.Console.WriteLine(); // пустая строка

// newText = Replace(newText, 'к', 'К'); // работаем с уже измененым текстом
// Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
       
       for (int j = i + 1; j < array.Length; j++) // j=i+1 необходимо уменьшить длинну массива на 1 в первом for
       {
            if(array[j] < array[minPosition]) minPosition = j;
       }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }  
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

