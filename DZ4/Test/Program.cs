using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age)[] users = CreateUsers();
            ShowMenu(users);
        }

        static (string name, int age)[] CreateUsers()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();
            (string name, int age)[] users = new (string name, int age)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = CreateUser();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return users;
        }

        static void ShowMenu((string name, int age)[] users)
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        PrintUsers(users);
                        break;
                    case 2:
                        PrintSelectedUser(users);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        static (string userName, int userAge) CreateUser()
        {
            Console.Write("Введите имя пользователя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int userAge = ReadInt();
            return (userName, userAge);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр всей базы данных");
            Console.WriteLine("2 - Просмотр пользователя");
            return ReadInt();
        }

        static void PrintSelectedUser((string name, int age)[] users)
        {
            int userIndex;
            do
            {
                Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
                userIndex = ReadInt();
            } while (userIndex < 0 || userIndex >= users.Length);

            PrintUser(users[userIndex]);
        }

        static void PrintUsers((string name, int age)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }

        static void PrintUser((string name, int age) user)
        {
            Console.WriteLine(FormatUserData(user));
        }

        static string FormatUserData((string name, int age) user)
        {
            return $"{user.name} ({user.age})";
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
