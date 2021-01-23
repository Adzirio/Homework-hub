using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Диагональ.");
            Console.Write("Введите желаемую длинну сторон двухмерного массива: ");
            string n = Console.ReadLine();
            int lenght = Convert.ToInt32(n);
            int[,] nArray = new int[lenght, lenght];
            int num = 0;
            for (int i = 0; i < nArray.GetLength(0); i++)
            {
                for (int j = 0; j < nArray.GetLength(0); j++)
                {
                    nArray[i, j] = num;
                    num++;
                }
            }
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(nArray[i, i]);
                if (i <  lenght - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
    }
}
