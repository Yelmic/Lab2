using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1= "programmer";
            string word2 = "programmer";
            string word3 = @"D:\proga\Lab2\lab2task2";
            string word4 = "D:proga\\Lab2\\lab2task2";
            string word5 = "D:proga/Lab2/lab2task2";
            Console.WriteLine(string.Compare(word1, word2));//0-similar words
            Console.WriteLine(string.Compare(word3, word4));//-1-fist>second
            Console.WriteLine(string.Compare(word2, word5));//1-first<second
            string s1 = "shine bright like a dimond";
            string s2 = "smells like teen spirit";
            string s3 = "all you need is love";
            Console.WriteLine(string.Concat(s1," ", s2));//слияние строк
            string s4 = string.Copy(s2);
            Console.WriteLine(s4);//копирование
            Console.WriteLine(s3.Substring(3, 9));//начиная с 3 позиции длинной 9
            string[] s5 = s1.Split(' ');//извлекаем пробелы
            Console.WriteLine("The number of words "+s5.Length);
            for (int i = 0; i < s5.Length; i++)//вывод слов 
            {
                Console.WriteLine(s5[i]);
            }
            Console.WriteLine(s2.Insert(7, word1));//с 7 позиции добавить подстроку
            Console.WriteLine(s3.Remove(0,4));//начиная с 0 позиции удалить 4 символа
            string s = "";
            string nl = null;
            Console.WriteLine(String.IsNullOrEmpty(s));//возвр true если пустая или нул
            Console.WriteLine(String.IsNullOrWhiteSpace(nl));//проверяет еще и табуляцию
            StringBuilder ns = new StringBuilder( "One step closer to me");
            Console.WriteLine(ns.Remove(4, 12));//начиная с 4 удалть 12
            Console.WriteLine(ns.Insert(0, "1"));//добавить 1 символ с 0 позиции 
            Console.WriteLine(ns.AppendFormat("t"));//добавить 1 символ в конце
        }
    }
}
