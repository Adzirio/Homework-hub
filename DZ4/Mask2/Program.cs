using System;

namespace Mask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько целых чисел, разделенных пробелом.");
            Console.WriteLine("Сумма введенных чисел равна: " + ConvertMassive(Console.ReadLine()));
        }
        static int ConvertMassive(string mas)
        {
            string num = "";
            int sum = 0;
            for (int i = 0; i < mas.Length; i++) { 
                char n = ' ';
                if (mas[i] != n)
                {
                    num += mas[i];
                    if (i == (mas.Length - 1))
                    {
                        int a = Convert.ToInt32(num);
                        sum += a;
                    }
                }
                else
                {
                    int a = Convert.ToInt32(num);
                    sum += a;
                    num = "";
                }
            }
            return sum;
        }
    }
}
