using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Введите числа массива");
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                sum+= array[i];
            }
            Console.WriteLine("Среднее арифметическое - {0}", (double)sum/array.Length);
            Console.ReadKey();
        }
    }
}
