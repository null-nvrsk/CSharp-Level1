// [Скоморохов Максим]
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_RecursiveFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим исходные данные
            Console.Write("Вводим целочисленные переменные\na = ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            // выполняем просчет и вывод результатов
            Console.WriteLine("1ая фунуция - вывод на экран чисел от a до b");
            DisplayCount(a, b);

            Console.WriteLine();
            Console.WriteLine("2ая фунуция - сумма чисел от a до b");
            Console.WriteLine(Sum(a, b));

            Console.ReadLine();
        }
        
        //---------------------------------------------------------------------
        // Последовальный вывод с рекурсией
        static void DisplayCount(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
                DisplayCount(a + 1, b);
        }

        //---------------------------------------------------------------------
        // Суммирование с рекурсией
        static int Sum(int a, int b)
        {
            if (a == b)
                return b;
            else
                return a + Sum(a + 1, b);
        }

    }
}
