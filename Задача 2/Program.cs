using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Console.WriteLine("Сгенерированный массив:");
            Random random = new Random();
            int min = 51;
            int max = -1;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального элементов массива - {0}", min+max);
            Console.ReadKey();
        }
    }
}
