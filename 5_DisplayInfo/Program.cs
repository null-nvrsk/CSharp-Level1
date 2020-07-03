// [ Скоморохов Максим ]
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим данные
            Console.Write("Ваше имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string lastName = Console.ReadLine();

            Console.Write("Город проживания: ");
            string city = Console.ReadLine();

            // подсчитываем координаты, чтобы сообщение было по центру
            string message = $"{firstName} {lastName}, {city}";
            int x = (Console.WindowWidth - message.Length) / 2;
            int y = Console.WindowHeight / 2;
         
            // Выводим на экран
            Console.Clear();
            Display(message, x, y);

            Console.ReadLine();
        }
        //----------------------------------------------------------------------------
        static void Display(string message, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
    }
}
