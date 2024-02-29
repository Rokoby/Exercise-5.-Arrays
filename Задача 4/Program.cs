﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
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

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i+1)%2 == 0 && array[i]%2 != 0 && array[i] > 0)
                    k++;
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах - {0}", k);
            Console.ReadKey();
        }
    }
}
