using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];

            Console.WriteLine("Сгенерированный массив:");
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            int a = 0;

            for (int i = 0 ;i < n/2; i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }

            for (int i = n/2; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Упорядоченный массив:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", array[i]);
            Console.ReadKey();
        }
    }
}
