using System;

namespace Mask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления числа Фибоначчи.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciNum(a));
        }
        static int FibonacciNum(int num)
        {
            int even = 0;
            int notEven = 1;
            for (int i = 1; i <= num; i++)
            {
                if ((i % 2) == 0)
                {
                    even += notEven;
                }
                else
                {
                    notEven += even;
                }
            }
            if (even > notEven || num == 0) 
            { 
                return even; 
            }
            else 
            { 
                return notEven; 
            }
        }
    }
}
