// [Скоморохов Максим]
// Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            bool successLogin = false;
            int tryCount = 1;
            string login = "root";
            string password = "GeekBrains";

            // Пробуем ввести логин/пароль
            do
            {
                Console.Clear();
                Console.WriteLine($"Вход пользователя. Попытка {tryCount}");
                Console.Write("Логин: ");
                string userLogin = Console.ReadLine();

                Console.Write("Пароль: ");
                string userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    successLogin = true;
                    break;
                }
                tryCount++;
            } while (tryCount <= 3);

            // Выводим результат
            Console.Clear();
            if(successLogin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступ разрешен");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Доступ запрещен");
            }

            Console.ReadLine();
        }
    }
}
