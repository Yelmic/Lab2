using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = true;//логический тит
            byte two = 144;//хранит целое число от 0 до 255
            sbyte three = -127;//хранит целое число от -128 до 127
            short four = -666;//хранит целое число от -32768 до 32767
            int five = 90;//целое число
            ushort six = 13;//целое число от 0 до 65535
            uint seven = 10000;//целое число от 0 до 42...
            long eight = 12222;//целое число
            ulong nine = 222222;//целое число
            double ten = 2.3;
            char twelve = 'y';
            string thirteen = "people";
            float fourteen = 3.14F;
            decimal fifteen = 334.8m;
            object sixteen = "tree";


            float y = (float)five;//1 явное преобразование
            sbyte u = (sbyte)five;//2 явное преобразование
            long i= (long)five;//3 явное преобразование
            short t= (short)five;//4 явное преобразование
            double g= (double)five;//5 явное преобразование
            Int32 first = 3;
            Int64 second = first;//1 неявное преобразование
            Single r = first;//2 неявное преобразование
            Object e = first;//3 неявное преобразование
            float w = first;//4 неявное преобразование
            double q = first;//5 неявное преобразование


            int pick = 4;
            Object l = pick;//упаковка pick
            byte lol=(byte)(int)pick;//распаковка pick


            var age = 33;
            var name = "Elena";
            Type agetype = age.GetType();
            Type nametype = name.GetType();
            Console.WriteLine("Type name: {0}", nametype);
            Console.WriteLine("Type age: {0}", agetype);


            Nullable<int> piece = 15;
            Console.WriteLine(piece.Value);
        }
    }
}
