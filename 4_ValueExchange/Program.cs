// [ Скоморохов Максим ]
// Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// б) * без использования третьей переменной.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числовых значения (дробная часть вводится через \",\"):");
            Console.Write("1 переменная = ");
            string first = Console.ReadLine();
            double firstDouble = Convert.ToDouble(first);

            Console.Write("2 переменная = ");
            string second = Console.ReadLine();
            double secondDouble = Convert.ToDouble(second);


            ExchangeWith3Vars(ref firstDouble, ref secondDouble);
            Console.WriteLine("\nЗначения обмена С использованием третьей переменной");
            Console.WriteLine($"1 переменная = {firstDouble}");
            Console.WriteLine($"2 переменная = {secondDouble}");

            // повторно присваиваем значения, т.к. после первой операции они поменялись
            //firstDouble = Convert.ToDouble(first);
            //secondDouble = Convert.ToDouble(second);

            ExchangeWith2Vars(ref firstDouble, ref secondDouble);
            Console.WriteLine("\nЗначения обмена БЕЗ использованием третьей переменной");
            Console.WriteLine($"1 переменная = {firstDouble}");
            Console.WriteLine($"2 переменная = {secondDouble}");

            Console.ReadLine();
        }

        //-----------------------------------------------------------------------------------
        // меняем значения переменных С использованием 3ей временной
        static void ExchangeWith3Vars(ref double first, ref double second)
        {
            double temp = first;
            first = second;
            second = temp;
        }

        //-----------------------------------------------------------------------------------
        // меняем значения переменных БЕЗ использования 3ей временной
        static void ExchangeWith2Vars(ref double first, ref double second)
        {
            first = first + second; // first = 1ая + 2ая
            second = first - second; // second = (1ая + 2ая) - 2ая = 1ая
            first = first - second; // first = (1ая + 2ая) - 1ая = 2ая
        }
    }
}
