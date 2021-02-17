using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mask3
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            string userNumber = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("number.bin", FileMode.OpenOrCreate), userNumber);
        }
    }
}
