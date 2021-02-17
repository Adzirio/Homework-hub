using System;

namespace Mask3
{
    class Program
    {
        enum Season
        {
            Зима,
            Весна,
            Лето,
            Осень
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца(числом).");
            int user = request();
            Console.WriteLine("Данному месяцу соответвует сезон: " + season(user));
        }
        static string season(int user)
        {
            string season = "";
            int[,] month = { { 12, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };
            for (int i = 0; i < month.GetLength(0); i++)
            {
                for (int j = 0; j < month.GetLength(1); j++)
                {
                    if (user == month[i, j])
                    {
                        season += (Season)i;
                    }
                }
            }
            return season;
        }
        static int request()
        {
            while (true)
            {
                int user = Convert.ToInt32(Console.ReadLine());
                if (user > 0 && user < 13)
                {
                    return user;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                }
            } 
        }
    }
}
