using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTuple <int, string, char, string, ulong> kortege = (23, "programm", 'u', "array", 56);
            Console.WriteLine("all kortege:");
            Console.WriteLine(kortege);
            Console.WriteLine("1,3,4 elements:");
            Console.WriteLine(kortege.Item1+" "+ kortege.Item3+" "+ kortege.Item4);
            (int one, string two, char three) = (90, "lab", 'o');
            Console.WriteLine($"unpackage {one} {two} {three}");//
            ValueTuple<int, string> kort1 = (9, "pro");
            ValueTuple<int, string> kort2 = (88, "one");
            if (kort1==kort2)
                Console.WriteLine("Первый кортеж равен второму");
            else
                Console.WriteLine("Первый кортеж не равен второму");

        }
    }
}
