using System;
using System.IO;
using System.Text.Json;


namespace Mask5
{
    class Program
    {
        //был создан массив объектов Quest в котором находятся задания класса ToDo.
        static void Main(string[] args)
        {
            string jsonFile = "Quest.json";
            string json = File.ReadAllText(jsonFile);
            ToDo[] Quest = JsonSerializer.Deserialize<ToDo[]>(json);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Список дел.\n");
                string completed = "";
                for (int i = 0; i < Quest.Length; i++)
                {
                    int num = (i + 1);
                    if (Quest[i].IsDone == true)
                    {
                        completed = ".[x] ";
                        Console.WriteLine(num + completed + Quest[i].Title);
                    }
                    else
                    {
                        completed = ".[o] ";
                        Console.WriteLine(num + completed + Quest[i].Title);
                    }
                }
                /////////
                Console.WriteLine("\nДля выхода пропишите: x");
                Console.Write("Введите номер задания для отметки: ");
                string userArray = Console.ReadLine();
                if ((userArray == "x") || (userArray == "х"))
                {
                    return;
                }
                /////////
                int userNum = Convert.ToInt32(userArray);
                if (Quest[userNum - 1].IsDone == true)
                {
                    Quest[userNum - 1].IsDone = false;
                    json = JsonSerializer.Serialize(Quest);
                    File.WriteAllText(jsonFile, json);
                }
                else
                {
                    Quest[userNum - 1].IsDone = true;
                    json = JsonSerializer.Serialize(Quest);
                    File.WriteAllText(jsonFile, json);
                }
            }
        }
    }
}
