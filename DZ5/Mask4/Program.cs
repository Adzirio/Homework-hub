using System;
using System.IO;

namespace Mask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к дерриктории.");
            string @userLink = Console.ReadLine();
            File.WriteAllLines("text.txt", Link(@userLink));//без рекурсии
            File.WriteAllText("text1.txt", "");
            File.AppendAllText("text1.txt", Recursive(Link(@userLink), "", 0));//с рекурсией
        }
        static string Recursive(string[] dirArray, string array,int i)
        {
            File.AppendAllText("text1.txt", array);
            if (dirArray.Length == i)
            {
                return "";
            }
            return Recursive(dirArray, dirArray[i] + "\n", i+1);
        }
        static string[] Link(string link)
        {
            string[] entries = Directory.GetFileSystemEntries(link, "*", SearchOption.AllDirectories);
            return entries;
        }
    }
}
