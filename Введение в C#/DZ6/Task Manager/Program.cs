using System;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessList();
            while (true)
            {
                Console.WriteLine("\nДля выхода пропишите: х");
                Console.Write("Введите ID процесса для его завершения: ");
                string id = Console.ReadLine();
                if (id == "x" || id == "х")
                {
                    break;
                }
                try
                {
                    using (Process program = Process.GetProcessById(int.Parse(id)))
                    {
                        program.Kill();
                        program.WaitForExit();
                        Console.Clear();
                        ProcessList();
                    }
                }
                catch
                {
                    Console.WriteLine("\n!!!Неверное значение!!!");
                    continue;
                }
            }
        }
        static void ProcessList()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"Name: ({process.Id}) {process.ProcessName}");
            }
        }
    }
}
