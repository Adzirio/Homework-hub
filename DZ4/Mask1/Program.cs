using System;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FullName = { "", "", "", "" };
            FullName[0] = GetFullName("Иванов", "Иван", "Иванович");
            FullName[1] = GetFullName("Сергеев", "Сергей", "Сергеевич");
            FullName[2] = GetFullName("Антонов", "Антон", "Антонович");
            FullName[3] = GetFullName("Зырянов", "Денис", "Сергеевич");
            for(int i = 0; i < FullName.Length; i++)
            {
                Console.WriteLine(FullName[i]);
            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
    }
}
