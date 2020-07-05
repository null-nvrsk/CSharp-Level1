// [Скоморохов Максим]
// Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MinThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Минимальное значение: " + MinThree(a, b, c));
            Console.ReadLine();
        }

        //---------------------------------------------------------------------
        static double MinThree(double n1, double n2, double n3)
        {
            // по умолчанию считаем минимальным n1
            double min = n1;
            if (n2 <= n1 && n2 <= n3) min = n2;
            else if (n3 <= n1 && n3 <= n1) min = n3;

            return min;
        }

    }
}
