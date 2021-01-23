using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реверсирование.");
            Console.Write("Введите желаемое слово: ");
            string userWord = Console.ReadLine();
            int n = userWord.Length;
            for (int i = 0; i < userWord.Length; i++)
            {
                n--;
                Console.Write(userWord[n]);
            }
        }
    }
}
