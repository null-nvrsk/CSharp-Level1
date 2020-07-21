// [Скоморохов Максим]
// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
// в)** Добавьте обработку ситуации отсутствия файла на диске.

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace _2_PairComparison
{
    class StaticClass
    {
        /// <summary>
        /// Возвращает количество пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="numbers">Весь целочисленный массив</param>
        /// <returns>количество парных элементов</returns>
        public static int PairComparison(int[] numbers) 
        {
            // сравнваем парные элементы
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // проверяем деление на 3
                // "!=" логический XOR, т.к. нету "^^" :)
                if ((numbers[i] % 3 == 0) != (numbers[i + 1] % 3 == 0))
                {
                    count++;
                }
            }

            return count;
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Считывания массива из текстового файла
        /// </summary>
        /// <param name="path">Путь к текстовому файлу с массивом</param>
        /// <returns>массив целых чисел</returns>
        public static int[] ReadArrayFromFile(string path)
        {
            int[] nums = {};

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    int count = 0;
                    string element;
                
                    while ((element = sr.ReadLine()) != null)
                    {
                        Array.Resize(ref nums, ++count);
                        nums[count - 1] = Convert.ToInt32(element);
                        Console.WriteLine(nums[count - 1]);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Файл не найден: {path}");
            }

            return nums;
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num">Количество элементов массива</param>
        /// <param name="minValue">Минимальное значение элемента</param>
        /// <param name="maxValue">Максимальное значение элемента</param>
        /// <returns>Готовый массив чисел</returns>
        public static int[] GetRandomArray(int num, int minValue, int maxValue)
        {
            int[] nums = new int[num];

            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(minValue, maxValue + 1);
                Console.Write($"{nums[i]}, ");
            }
            Console.WriteLine();

            return nums;
        }
    }
}
