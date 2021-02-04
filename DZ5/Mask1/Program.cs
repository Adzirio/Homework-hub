using System;
using System.IO;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("text.txt", Console.ReadLine());
        }
    }
}
