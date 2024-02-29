using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt16(Console.ReadLine());
            int [,]array = new int[n,n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n;j++)
                {
                    if ((i%2==0 && j%2==0)||(i%2!=0 && j%2!=0))
                        array[i, j] = 1;
                    else
                        array[i,j] = 0;
                }  
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
