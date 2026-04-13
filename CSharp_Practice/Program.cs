using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_13_04_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();


        }


        static void Task1()
        {
            int[] arr = new int[10] { 0, 0, 1, 2, 3, 4, 5, 0, 0, 0 };
            
            foreach (int i in arr)
            {
                if (i == 0)
                {
                    int indexToRemove = i;
                    int[] newarr = new int[arr.Length - 1];
                    foreach (int j in newarr)
                    {
                        if (j != i)
                        {
                            newarr[j] = arr[i];
                            
                        }
                        arr = newarr;
                        
                    }
                    Console.WriteLine(newarr);
                }

            }

        }
    }
}
