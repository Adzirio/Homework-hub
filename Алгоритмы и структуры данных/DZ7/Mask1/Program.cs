using System;
using System.Collections.Generic;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int M = 8;
            int[,] A = new int[N, M];
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1;
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }
            Console.WriteLine(A[(N - 1), (M - 1)]); //330
        }
    }
}
