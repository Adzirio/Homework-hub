using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Properties.Settings.Default.UserName;
            string greeting = Properties.Settings.Default.Greeting;

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.UserAge) || string.IsNullOrEmpty(Properties.Settings.Default.UserActivity))
            {
                Console.Write("Не зарегистрированный пользователь.\nВведите запрашиваемые данные.\nИмя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Возраст: ");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Console.Write("Вид деятельности: ");
                Properties.Settings.Default.UserActivity = Console.ReadLine();

                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"{greeting}, {userName}");
            }
            Console.Write("\nДля выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
