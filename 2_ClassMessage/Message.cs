using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassMessage
{
    class Message
    {
        /// <summary>
        /// Вывести только те слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="message">Текст исходного сообщения</param>
        /// <param name="maxLetters">Максимально допустимая длина слова</param>
        /// <returns>Слова, которые содержат не более n букв.</returns>
        static public string GetWordsWithLettersLess(string message, int maxLetters)
        {
            string[] words = message.Split(new Char[] { ' ', ',', '.' });
            string newWords = "";

            for (int i = 0; i < words.Length; i++)
            {
                int wordLen = words[i].Length;
                if (wordLen <= maxLetters && wordLen > 0)
                    newWords += words[i] + " ";
            }

            return newWords;
        }

        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="message">Текст исходного сообщения</param>
        /// <param name="letter">Буква, которая должна быть в конце слова</param>
        /// <returns>слова, в которых не заканчиваются на заданный символ</returns>
        static public string DeleteWordsWithEndLetter(string message, char letter)
        {
            string[] words = message.Split(new Char[] { ' ', ',', '.' });
            string newWords = "";

            for (int i = 0; i < words.Length; i++)
            {
                int wordLen = words[i].Length;
                if (wordLen > 0)
                {
                    // Если последняя буква слова не является заданным символом
                    if (words[i][wordLen - 1] != letter)
                        newWords += words[i] + " ";
                }
                
            }

            return newWords;
        }

        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Найти самое длинное слово сообщения
        /// </summary>
        /// <param name="message">Текст исходного сообщения</param>
        /// <returns>Самое длинное число. Если несколько одинаковых по длине, то возврается первое</returns>
        static public string TheLongestWord(string message)
        {
            string[] words = message.Split(new Char[] { ' ', ',', '.' });
            string longestWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                    longestWord = words[i];
            }

            return longestWord;
        }

        //-----------------------------------------------------------------------------------
        static public string LongestWords(string message)
        {
            int maxLen = 0;
            string[] words = message.Split(new Char[] { ' ', ',', '.' });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                int currenwWordLen = words[i].Length;

                // Если найден новый максимум, то обнуляем список
                if (currenwWordLen > maxLen)
                {
                    maxLen = currenwWordLen;
                    sb.Clear();
                    sb.Append(words[i] + " ");
                }
                // если найдено слово максимальной длины, то добавляем список  
                else if (currenwWordLen == maxLen)
                {
                    sb.Append(words[i] + " ");
                }
            }

            return sb.ToString();
        }
    }
}
