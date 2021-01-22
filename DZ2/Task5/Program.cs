using System;
using AvgTemp = Task1.Program;
using MonthName = Task2.Program;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = AvgTemp.AverageTemp();
            var month = MonthName.MonthAnswer();
            if (temp > 0 && month < 3 || month == 12)
            {
                Console.WriteLine("Дождливая зима.");
            }
        }
    }
}
