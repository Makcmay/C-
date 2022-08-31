using System;

namespace Home4

{
    class Program
    {
        static void Main(string[] agrs)
        {
            Task27();
        

             static void Task27()
            {
                Console.Write("Введите число :");
                int num = int.Parse(Console.ReadLine());

                int result = 0;
                int length = (int)Math.Log10(num);

                for (int i = 0; i < length + 1; i++)
                {
                    result = result + num % 10;
                    num /= 10;
                }

                Console.WriteLine($"Сумма цифр в числе = {result}");
            }


            
        
        }
        
    }

}

