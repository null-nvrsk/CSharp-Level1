// [Скоморохов Максим]
// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    partial class Program
    {



        static void Main(string[] args)
        {

            // Загружаем список аккаунтом
            Accounts.LoadAccountsFromFile("accounts.txt");

            
            bool successLogin = false;
            int tryCount = 1;

            // Пробуем ввести логин/пароль
            do
            {
                // Пользватель вводит логин и пароль
                Console.Clear();
                Console.WriteLine($"Вход пользователя. Попытка {tryCount}");
                Console.Write("Логин: ");
                string userLogin = Console.ReadLine();

                Console.Write("Пароль: ");
                string userPassword = Console.ReadLine();

                // проверям введеный логин/пароль
                if (Accounts.CheckAccount(userLogin, userPassword))
                {
                    successLogin = true;
                    break;
                }
                tryCount++;
            } while (tryCount <= 3);

            // Выводим результат
            Console.Clear();
            if (successLogin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступ разрешен");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Доступ запрещен");
            }

            Console.ReadLine();

        }

        
    }
}
