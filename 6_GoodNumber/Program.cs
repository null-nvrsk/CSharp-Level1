// [Скоморохов Максим]
//* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, используя структуру DateTime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_GoodNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int totalCount = 1_000_000;
            int goodCount = 0;
            for (int i = 1; i <= totalCount; i++)
            {
                if (GoodNumber(i))
                {
                    goodCount++;
                    Console.WriteLine(i);
                }
            }

            Console.Write("Всего хороших чисел: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(goodCount);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Время посчета: " + (DateTime.Now - start));

            // 2ой раз подсчитыаем без вывода в консоль
            start = DateTime.Now;
            for (int i = 1; i <= totalCount; i++)
            {
                if (GoodNumber(i))
                    goodCount++;
            }

            Console.WriteLine("Время посчета (без вывода списка хороших чисел): " + (DateTime.Now - start));

            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        // Проверка «хороших» чисел
        static bool GoodNumber(int number)
        {
            int sumOfDigits = 0;
            int startNumber = number;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            // проверяем остаток от деления 
            return (startNumber % sumOfDigits == 0) ? true : false;
        }
    }
}
