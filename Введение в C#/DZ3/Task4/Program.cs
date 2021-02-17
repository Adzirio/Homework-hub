using System;

namespace Mask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] SB = new string[10, 10];
            for (int i = 0; i < SB.GetLength(0); i++)
            {
                for (int j = 0; j < SB.GetLength(1); j++)
                {
                    SB[i, j] = "O ";
                }
            }
            SB[5, 6] = "X "; 
            SB[8, 3] = "X ";
            SB[8, 5] = "X ";
            SB[9, 0] = "X ";
            SB[0, 0] = "X "; SB[0, 1] = "X ";
            SB[2, 9] = "X "; SB[3, 9] = "X ";
            SB[8, 8] = "X "; SB[9, 8] = "X ";
            SB[0, 3] = "X "; SB[1, 3] = "X "; SB[2, 3] = "X ";
            SB[4, 1] = "X "; SB[5, 1] = "X "; SB[6, 1] = "X ";
            SB[0, 6] = "X "; SB[0, 7] = "X "; SB[0, 8] = "X "; SB[0, 9] = "X ";
            for(int i=0; i < SB.GetLength(0); i++)
            {
                for (int j = 0; j < SB.GetLength(1); j++)
                {
                    Console.Write(SB[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
