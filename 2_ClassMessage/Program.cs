// [Скоморохов Максим]
// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения,  которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = " Lorem ipsum dolor sit amet, adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine($"Исходное сообщение:\n{message}\n----------------");

            int maxLetters = 5;
            string msgEdit1 = Message.GetWordsWithLettersLess(message, maxLetters);
            Console.WriteLine($"Сообщение, со словами до {maxLetters} букв (включительно):\n{msgEdit1}\n----------------");

            char lastExclude = 't';
            string msgEdit2 = Message.DeleteWordsWithEndLetter(message, lastExclude);
            Console.WriteLine($"Сообщение, в котором нет слов заканчиваются на {lastExclude}:\n{msgEdit2}\n----------------");


            string msgEdit3 = Message.TheLongestWord(message);
            Console.WriteLine($"Cамое длинное слово сообщения:\n{msgEdit3}\n----------------");

            string msgEdit4= Message.LongestWords(message);
            Console.WriteLine($"Cамые длинные слова сообщения:\n{msgEdit4}\n----------------");

            Console.ReadLine();
        }
    }
}
