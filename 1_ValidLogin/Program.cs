// [Скоморохов Максим]
// Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) ** с использованием регулярных выражений.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_ValidLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод логина
            Console.Write("Введите логин (2 до 10 символов): ");
            string userLogin = Console.ReadLine();

            // проверка валидности 2 методами
            bool valid = CheckLoginValidation(userLogin);           
            bool validRegex = CheckLoginRegexValidation(userLogin);

            // выводим результат
            Console.WriteLine("Без RegEx: " + (valid ? "валидный логин" : "невалидный логин"));
            Console.WriteLine("С RegEx: " + (validRegex ? "валидный логин" : "невалидный логин"));

            Console.ReadLine();
        }


        //---------------------------------------------------------------------
        /// <summary>
        /// Проверка валидности логина без RegEx
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <returns>Валидность</returns>
        static bool CheckLoginValidation(string login)
        {
            // проверяем длину (2-10 симболов)
            if (login.Length < 2 || login.Length > 10) 
                return false;

            // проверяем что 1 буква латинская
            if (!char.IsLetter(login[0]))
                return false;

            // проверяем остальные буквы что латинские или цифры
            for (int i = 1; i < login.Length; i++)
            {
                if (!char.IsLetterOrDigit(login[i])) 
                    return false;
            }

            // Если прошли все проверки
            return true;
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Проверка валидности логина с использованием RegEx
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <returns>Валидность</returns>
        private static bool CheckLoginRegexValidation(string login)
        {
            Regex myReg = new Regex(@"^[A-Za-z][A-Za-z0-9]{1,9}$");
            return myReg.IsMatch(login);
        }
    }
}
