using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
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

        static void Task2()
        {
            int countindex = 0;
            int[] arr = new int[10] { -1, 2, 3, -4, -13, 5, 1, -9, 5, 0 };

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    countindex += 1;

                }

            }

            int[] newarr = new int[arr.Length];


            for (int i = 0, j = 0; i < arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    newarr[j] = arr[i];
                    j++;
                }
                

            }


            for (int i = 0, j = 1; j < countindex + 1 ;i++)
            {
                if (arr[i] > 0)
                {
                    newarr[newarr.Length - j] = arr[i];
                    j++;
                }


            }
       

            arr = newarr;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
        
        static void Task3()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = 0;

            Console.WriteLine("Enter your number to search: ");
            int input = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i] == input)
                {
                    count ++;
                }
            }
            Console.WriteLine($"Your number has been found {count} times\n\t");
            Task3();

        }

        static void Task4()
        {
            int[,] OArr = 
            { 
                { 1, 2, 3 }, 
                { 1, 2, 3 }, 
                { 1, 2, 3 }, 
                { 1, 2, 3 } 
            };


            int ALine = OArr.GetLength(0);
            int AColumn = OArr.GetLength(1);

            int[,] NArr = new int[AColumn, ALine];

            for (int i = 0, j = 0; i < ALine;)
            {
                NArr[j, i] = OArr[i, j];
                
                j++;

                if (j == AColumn)
                {
                    j = 0;
          
                    i++;
           
                    if (i == ALine) break;
                    
                }
                
            }
            for (int Lin = 0, Col = 0; Lin < ALine;)
            {
                Console.WriteLine(NArr[Col, Lin]);

                Lin++;
                if (Lin == ALine)
                {
                    Lin = 0;
                    
                    Col++;
                    Console.WriteLine("!");
                }
                
                
            }







        }

        static void Task5()
        {
            int[] A = new int[5];
            int[,] = new int[4, 3];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"\rВведите числое под индексом {i}: ");
                int input = Convert.ToInt32(Console.Read());

                A[i] = input;
            }
            for (int i = 0; i < A.Length;)
            {
                Console.Write(A[i]);
                i++;

            }
        }
       
        static void Main(string[] args)
        {
            Task5();
            
            Console.Read();

        }
    }
}
