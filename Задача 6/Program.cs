using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine("Введите числа массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j]= Convert.ToInt16(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += array[0, i];
            bool k = false;
            int sumS = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumS += array[i, j];
                }
                if(sumS!=sum)
                {
                    k = true;
                    sumS = 0;
                    break;
                }
                sumS = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumS += array[j, i];
                }
                if (sumS != sum)
                {
                    k = true;
                    sumS = 0;
                    break;
                }
                sumS = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i==j)
                        sumS += array[i, j];
                }
            }
            if (sumS != sum)
            {
                k = true;
            }
            sumS = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i+j==n-1)
                        sumS += array[i, j];
                }
            }
            if (sumS != sum)
            {
                k = true;
            }
            if (k == true)
                Console.WriteLine("Матрица не является магическим квадратом");
            else
                Console.WriteLine("Матрица является магическим квадратом");
            Console.ReadKey();
        }
    }
}
