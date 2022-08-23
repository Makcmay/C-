void FillArray(int[] collection) // Метод заполнение массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // присвоить аргументу с индексом любое рандомное число от 1 до 10
        index++;
    }
}

void PrintArray (int[] col) // Метод вывода массисва на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[]collection, int find) // Метод поиска позиции аргумента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для того чтобы когда задан элемент отсутсвующий выдавало не 0, а позицию -1 (отсутвует в массиве)
    while ( index < count )
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++; 
    }
    return position;
}

int[] array = new int[10]; // new int[10] создай массив из 10 элементов (все элементы по умолчанию 0)
FillArray(array);
PrintArray(array);
System.Console.WriteLine(); // выводит пустую строку

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);