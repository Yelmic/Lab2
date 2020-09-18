using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task a");
            Console.WriteLine("Введите размер массива");
            int n = Int32.Parse(Console.ReadLine());//ввод строк
            int m = Int32.Parse(Console.ReadLine());//ввод столбцов

            int[,] massive = new int[n, m];//создание массива

            Random ran = new Random();//использование рандомных чисел

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    massive[i, j] = ran.Next(1, 100);//заполняем массив числами, к-е варьируются от 1 до 100
                    Console.Write("{0}\t", massive[i, j]);//вывод через табуляцию
                }
                Console.WriteLine();
            }


            Console.WriteLine("task b");
            string word = "const";
            string[] array = new[] { "check in", "pull out", "be happy", "knock knock" };
            Console.WriteLine("The elements of array:");
            foreach (string i in array)
            {
                
                Console.WriteLine(i);
            }
            Console.WriteLine("The Lenght of array");
            Console.WriteLine(array.Length);
            array[2] = word;
            foreach (string i in array)
            {

                Console.WriteLine(i);
            }


            Console.WriteLine("task c");
            double[][] mass = new double[3][];
            mass[0] = new double[2];
            mass[1] = new double[3];
            mass[2] = new double[4];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Enter the element");
                int element = Int32.Parse(Console.ReadLine());
                mass[0][i] = element;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the element");
                int element = Int32.Parse(Console.ReadLine());
                mass[1][i] = element;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the element");
                int element = Int32.Parse(Console.ReadLine());
                mass[2][i] = element;
            }
            for (int i = 0; i < 2; i++)
                Console.Write(mass[0][i] + " ");
            Console.WriteLine();
            // Вывести значения из второго массива,
            for (int i = 0; i < 3; i++)
                Console.Write(mass[1][i] + " ");
            Console.WriteLine();
            // Вывести значения из третьего массива.
            for (int i = 0; i < 4; i++)
                Console.Write(mass[2][i] + " ");
            Console.WriteLine();

            Console.WriteLine("task d");
            var massivchic = new[] { 14, 24, 30 };
            Console.WriteLine("the type of array - {0}", massivchic.GetType());
            var masic = new[] { "programmer", "footballer", "lashmaker" };
            Console.WriteLine("the type of array - {0}", masic.GetType());
        }
    }
}
