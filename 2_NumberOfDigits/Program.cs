// [Скоморохов Максим]
// Написать метод подсчета количества цифр числа.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_NumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное цисло: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество цифр = " + NumberOfDigits(userNumber));
            Console.ReadLine();
        }
        //---------------------------------------------------------------------
        static int NumberOfDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }

    }
}
