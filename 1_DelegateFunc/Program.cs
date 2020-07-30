// [Скоморохов Максим]
// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DelegateFunc
{

    delegate double Func(double a, double x);

    class Program
    {
        // Создаем метод, который принимает делегат
        public static void TableForm(Func F, double a, double minX, double maxX)
        {
            Console.WriteLine("----- A -------- X -------- Y ----");
            while (minX <= maxX)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, minX, F(a, minX));
                minX += 0.5;
            }
            Console.WriteLine("----------------------------------");
        }
        //-----------------------------------------------------------------
        // Создаем 1 метод для передачи его в качестве параметра в TableForm
        public static double MyFunc1(double a, double x)
        {
            return a *  Math.Pow(x, 2);
        }

        //-----------------------------------------------------------------
        // Создаем 2 метод для передачи его в качестве параметра в TableForm
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        //-----------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.Write("Ыыдите значение переменный a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = a * x^2");
            TableForm(MyFunc1, a, -5, 5);

            Console.WriteLine("y = a * sin(x)");
            TableForm(MyFunc2, a, -5, 5);

            Console.ReadLine();
        }
    }
}
