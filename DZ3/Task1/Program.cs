using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Диагональ.");
            Console.Write("Введите желаемое слово: ");
            string userWord = Console.ReadLine();
            string n = "";
            for (int i = 0; i < userWord.Length; i++)
            {
                Console.Write(n + userWord[i]);
                Console.WriteLine();
                n += "  ";
            }

        }
    }
}
