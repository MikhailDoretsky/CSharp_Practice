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
            List<int> indexes = new List<int>();
            int[] arr = new int[10] { 1, 2, 3, 4, 0, 5, 1, 9, 0, 0 };

            foreach (int i in arr)
            {
                if (int == 0)
                {
                    indexes.Add(i);
                    
                }

            }

            int[] newarr = new int[arr.Length - indexes.Count]

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {
                    newarr[j] = arr[j];
                }
                
            }
            Console.WriteLine(newarr);

        }

        static void Main(string[] args)
        {
            Task1();


        }  
    }
}
