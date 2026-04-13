using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_13_04_2026
{
    internal class Program
    {
        static void Task1()
        {
            int countindex = 0;
            int[] arr = new int[10] { 1, 2, 3, 4, 0, 5, 1, 9, 0, 0 };

            foreach (int i in arr)
            {
                if (i == 0)
                {
                    countindex += 1;

                }

            }

            int[] newarr = new int[arr.Length];


            for (int i = 0, j = 0; i < arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    newarr[j] = arr[i];
                    j++;
                }
                

            }
            for(int i = 1; i < countindex + 1;i++)
            {
                newarr[newarr.Length - i] = -1;
            }

            arr = newarr;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            

        }

        static void Main(string[] args)
        {
            Task1();
            Console.Read();

        }
    }
}
