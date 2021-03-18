using System;
using System.Collections.Generic;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 8;
            int[,] Array = new int[A, B];
            int i, j;
            for (j = 0; j < B; j++)
                Array[0, j] = 1;
            for (i = 1; i < A; i++)
            {
                Array[i, 0] = 1;
                for (j = 1; j < B; j++)
                    Array[i, j] = Array[i, j - 1] + Array[i - 1, j];
            }
            Console.WriteLine(Array[(A - 1), (B - 1)]); //330
        }
    }
}
