// [Скоморохов Максим]
// Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PairComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Генерируем массив
            int[] numbers = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-10000, 10001);
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();
                

            // сравнваем парные элементы
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                // проверяем деление на 3
                // "!=" логический XOR, т.к. нету "^^" :)
                if ((numbers[i] % 3 == 0) != (numbers[i+1] % 3 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine($"Найдено подходящих пар: {count}");
            Console.ReadLine();

        }
    }
}
