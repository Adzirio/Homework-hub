using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Телефонный справочник.");
            string[,] directory = new string[5, 2];
            directory[0, 0] = "Андрей    "; directory[0, 1] = "andrey@gmail.com";
            directory[1, 0] = "Никита    "; directory[1, 1] = "nikita@mail.ru";
            directory[2, 0] = "Александр "; directory[2, 1] = "sasha@gmail.com";
            directory[3, 0] = "Алексей   "; directory[3, 1] = "alesha@mail.ru";
            directory[4, 0] = "Денис     "; directory[4, 1] = "dziro744@gmail.com";
            Console.WriteLine("Проверка: ");
            int n = 0;
            do
            {
                string a = Console.ReadLine();
                n = Convert.ToInt32(a);
                if (n >= 5)
                {
                    break;
                }
                Console.WriteLine(directory[n, 0] + directory[n, 1]);
            } while (n < 5);
        
        }
    }
}
