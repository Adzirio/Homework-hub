using System;

namespace Task6
{
    class Program
    {
        enum dayWeek
        {
            Понедельник = 0b_0000001,
            Вторник     = 0b_0000010,
            Среда       = 0b_0000100,
            Четверг     = 0b_0001000,
            Пятница     = 0b_0010000,
            Суббота     = 0b_0100000,
            Воскресенье = 0b_1000000
        }
        static void Main(string[] args)
        {
            //В моем случае 1й офис работает с ПН по ПТ и 2й офис наоборот с ПТ по ПН.
            Console.WriteLine("Битовые маски.");
            Console.Write("Введите желаемый день недели: ");
            string day = Console.ReadLine();
            day = day.ToLower();
            dayWeek firstOffice = dayWeek.Понедельник | dayWeek.Вторник | dayWeek.Среда | dayWeek.Четверг | dayWeek.Пятница;
            dayWeek secondOffice = dayWeek.Пятница | dayWeek.Суббота | dayWeek.Воскресенье | dayWeek.Понедельник;
            byte dayChek = 0;
            switch (day)
            {
                case "понедельник":
                    dayChek = 0b_0000001;
                    break;
                case "вторник":
                    dayChek = 0b_0000010;
                    break;
                case "среда":
                    dayChek = 0b_0000100;
                    break;
                case "четверг":
                    dayChek = 0b_0001000;
                    break;
                case "пятница":
                    dayChek = 0b_0010000;
                    break;
                case "суббота":
                    dayChek = 0b_0100000;
                    break;
                case "воскресенье":
                    dayChek = 0b_1000000;
                    break;
            }
            dayWeek firstWork = firstOffice & (dayWeek)dayChek;
            dayWeek secondWork = secondOffice & (dayWeek)dayChek;
            bool firstOfficeWork = firstWork == (dayWeek)dayChek;
            bool secondOfficeWork = secondWork == (dayWeek)dayChek;
            bool allOfficeWork = firstOfficeWork == secondOfficeWork;
            if (allOfficeWork)
            {
                Console.WriteLine("Работают оба офиса.");
                return;
            }
            if (firstOfficeWork)
            {
                Console.WriteLine("Работает 1й офис.");
            }
            if (secondOfficeWork)
            {
                Console.WriteLine("Работает 2й офис.");
            }
        }
    }
}
