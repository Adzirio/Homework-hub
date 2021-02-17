using System;
using System.IO;

namespace Mask2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("startup.txt", (Console.ReadLine()+"\n"+DateTime.Now));
        }
    }
}
