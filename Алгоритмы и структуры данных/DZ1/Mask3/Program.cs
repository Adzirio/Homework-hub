using System;

namespace Mask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            Recursive(n);    //144
            int N = 10;
            NoRecursive(N);  //55
        }
        static int Recursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Recursive(n - 2) + Recursive(n - 1);
        }
        static int NoRecursive(int n)
        {
            int even = 0;
            int notEven = 1;
            for(int i = 1; i < n; i++)
            {
                if (even < notEven)
                {
                    even += notEven;
                }
                else
                {
                    notEven += even;
                }
            }
            if (even > notEven || n == 0) 
            {
                return even;
            }
            return notEven;
        }
    }
}
