// [Скоморохов Максим]
// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

using System;
using System.IO;

namespace Login
{
    partial class Program
    {
        struct Account
        {
            public string login;
            public string password;
        }


        class Accounts
        {
            static private Account[] accounts;

            //---------------------------------------------------------
            /// <summary>
            /// Загружаем пары логин/пароль (2 строки) из текстового файла
            /// </summary>
            /// <param name="path">Путь к файлу с логинами/паролями</param>
            /// <returns>Успешность прочтения файла</returns>
            static public bool LoadAccountsFromFile(string path)
            {
                // обнуляем список логин/паролей
                Array.Resize(ref accounts, 0);

                try
                {
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        int count = 0;
                        string login;
                        string password;

                        while ((login = sr.ReadLine()) != null)
                        {
                            // Если строка логина считана, а строки пароля нету, то выходим
                            if ((password = sr.ReadLine()) == null) break;

                            System.Array.Resize(ref accounts, ++count);
                            accounts[count - 1].login = login;
                            accounts[count - 1].password = password;
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл не найден: {path}");
                    return false;
                }

                return true;
            }

            //--------------------------------------------------------------
            /// <summary>
            /// Проверяем на валидность
            /// </summary>
            /// <param name="login">Логиин</param>
            /// <param name="password">Пароль</param>
            /// <returns>Валидность пары логин/пароль</returns>
            static public bool CheckAccount(string login, string password)
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].login == login && accounts[i].password == password)
                        return true;
                }

                return false;
            }
        }
    }
}
