using System;
using System.Collections.Generic;

namespace MetricsManager
{
    public class ValuesHolder
    {
        public class Value
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
        public List<Value> Array { get; set; }
        public void Add(string temp)
        {
            var value = new Value { Date = DateTime.Now, TemperatureC = Convert.ToInt32(temp) };
            Array.Add(value);
        }
        public void Read()
        {
            for (int i = 0; i < Array.Count; i++)
            {
                Console.WriteLine($"{Array[i].Date.ToString("HH.mm.ss")}/t{Array[i].TemperatureC}C, {Array[i].TemperatureF}F.");
            }
        }
        public void Delete(string temp)
        {
            for (int i = 0; i < Array.Count; i++)
            {
                if (Convert.ToString(Array[i].TemperatureC) == temp)
                {
                    Array.RemoveAt(i);
                    return;
                }
            }
        }
        public void Update(string stringToUpdate, string newValues)
        {
            for (int i = 0; i < Array.Count; i++)
            {
                if (Convert.ToString(Array[i].TemperatureC) == stringToUpdate)
                {
                    Array[i].TemperatureC = Convert.ToInt32(newValues);
                    return;
                }
            }
        }
    }
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
