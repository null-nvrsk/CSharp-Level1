// [Скоморохов Максим]
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SumOddPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа (0 - конец):");
            int number;
            int sum = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number % 2 == 1)
                    sum += number;
            } while (number != 0);

            // Выводим результат
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sum}");
            Console.ReadLine();
        }
    }
}
