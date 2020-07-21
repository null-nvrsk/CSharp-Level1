// [Скоморохов Максим]
// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
// в)** Добавьте обработку ситуации отсутствия файла на диске.

using System;

namespace _2_PairComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] randomNumbers = StaticClass.GetRandomArray(20, -10000, 10000);

            int[] numbers = StaticClass.ReadArrayFromFile("data.txt");

            int count = StaticClass.PairComparison(numbers);

            Console.WriteLine($"Найдено подходящих пар: {count}");
            Console.ReadLine();
        }
    }
}
