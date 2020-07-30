// [Скоморохов Максим]
// Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
// в) отсортировать список по возрасту студента;
// г) * отсортировать список по курсу и возрасту студента;


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Students
{
    class Student
    {
        public string lastName;
        public string firstName;
        public int course;
        public int age;

        public Student(string firstName, string lastName, int course, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.course = course;
            this.age = age;
        }
    }

    //-------------------------------------------------------------------------
    class Program
    {
        static int MyDelegat(Student st1, Student st2)
        {
            if (st1.age > st2.age)
                return 1;
            else if (st1.age < st2.age)
                return -1;
            else return 0;
        }

        //-------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int course5or6 = 0;
            int[] age18to20 = {0, 0, 0, 0, 0, 0 };
            List<Student> list = new List<Student>();                             

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));
                    Student lastStudent = list[list.Count - 1];

                    // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
                    if (lastStudent.course == 5 || lastStudent.course == 6)
                        course5or6++;

                    // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
                    if (lastStudent.age >= 18 && lastStudent.age <= 20)
                        age18to20[lastStudent.course - 1]++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            //
            Console.WriteLine("студентов в возрасте от 18 до 20 лет:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{i+1} курс - {age18to20[i]} человек");
            }


            Console.WriteLine("-----------------------");
            Console.WriteLine("Cтуденты (по возрасту)");

            // в) отсортировать список по возрасту студента;
            list.Sort(new Comparison<Student>(MyDelegat));


            foreach (var v in list) 
                Console.WriteLine($"| {v.firstName,10} | {v.lastName,12} | {v.age,2} | {v.course,1} |");

            Console.ReadKey();
        }
    }
}
