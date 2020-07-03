// [ Скоморохов Максим ]
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
// б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим координаты
            Console.Write("Введите координаты 1ой точки\nx1 = ");
            string x1string = Console.ReadLine();
            double x1 = Convert.ToDouble(x1string);

            Console.Write("y1 = ");
            string y1string = Console.ReadLine();
            double y1 = Convert.ToDouble(y1string);

            Console.Write("Введите координаты 2ой точки\nx2 = ");
            string x2string = Console.ReadLine();
            double x2 = Convert.ToDouble(x2string);

            Console.Write("y2 = ");
            string y2string = Console.ReadLine();
            double y2 = Convert.ToDouble(y2string);

            // Выводим растояние
            Console.WriteLine("Расстояние = {0:F2}", PointDistance(x1, y1, x2, y2));

            Console.ReadLine();            
        }

        //----------------------------------------------------------------------------------------
        // Формула расчета растояния
        static double PointDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
