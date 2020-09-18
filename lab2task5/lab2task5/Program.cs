using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "movement out";
           int[] array= new int[4] { 12, 3, 89, 7 };
            
            var result = GetResult(array, word);
            Console.WriteLine(result);
            Console.Read();
        }

        private static (int, int, string) GetResult(int[] array, string word)
        {
            int max = 0;
            int min = 1000;
            for(int i=0; i< 4; i++)
            {
                if(array[i]>max)
                {
                    max=array[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < min)
                {
                    min=array[i];
                }
            }
            string newword = word.Remove(1,11);
            var result = (max, min, newword);
            return result;
        }
    }
    
}

