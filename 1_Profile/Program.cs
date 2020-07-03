// [ Скоморохов Максим ]
// Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
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

            Console.Write("Ваш рост (в метрах): ");
            string heightString = Console.ReadLine();
            double height = Convert.ToDouble(heightString);

            Console.Write("Ваш вес (в килограмммах): ");
            string weightString = Console.ReadLine();
            int weight = Convert.ToInt32(weightString);

            // выводим в 1 строку (склеивание)
            string textBonding = firstName + " " + lastName + ", " + height + " м, " + weight + " кг";
            Console.WriteLine(textBonding);

            // выводим в 1 строку (спользуя форматированный вывод)
            string textFormated = string.Format("{0} {1}, {2} м, {3} кг", firstName, lastName, height, weight);
            Console.WriteLine(textFormated);

            // выводим в 1 строку (используя вывод с интерполяцией строк)
            string textInterpolation = $"{firstName} {lastName}, {height} м, {weight} кг";
            Console.WriteLine(textInterpolation);

            Console.ReadLine();
        }
    }
}
