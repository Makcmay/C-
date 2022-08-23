int[] array = { 1, 12, 13, 4, 18, 16, 17, 18 }; //определить позицию искомого

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
   if (array[index] == find)
   {
    System.Console.WriteLine(index);
    break; // остановить на первом искомом
   } 
   index++;
}
