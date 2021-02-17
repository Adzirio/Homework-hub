using System;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;  //Не простое
                        //Простыми являются числа 1,2,3
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            string answer = "";
            if (d == 0)
            {
                answer = "Простое";
            }
            else
            {
                answer = "Не простое";
            }
            Console.WriteLine(answer);
        }
    }
}
