using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AverageTemp();
        }
        public static float AverageTemp()
        {
            Console.WriteLine("Определение среднесуточной температуры.");
            Console.Write("Пожалуйста, введите минимальную температуру за сутки: ");
            string a = Console.ReadLine();
            float min = Convert.ToInt32(a);
            Console.Write("Пожалуйста, введите максимальную температуру за сутки: ");
            string b = Console.ReadLine();
            float max = Convert.ToInt32(b);
            float AverageTemp = (min + max) / 2;
            Console.WriteLine("Средняя температура равняется: " + AverageTemp);
            Console.WriteLine("");
            return AverageTemp;
        }
    }
}
