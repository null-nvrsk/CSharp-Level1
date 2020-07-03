
// [ Скоморохов Максим ]
// Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваш вес (в килограмммах): ");
            string weightString = Console.ReadLine();
            int weight = Convert.ToInt32(weightString);

            Console.Write("Ваш рост (в метрах): ");
            string heightString = Console.ReadLine();
            double height = Convert.ToDouble(heightString);

            double index = weight / (height * height);

            Console.WriteLine($"Индекс массы тела = {index}");

            Console.ReadLine();
        }
    }
}
