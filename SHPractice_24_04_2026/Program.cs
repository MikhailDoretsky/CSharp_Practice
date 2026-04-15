using System;
using System.Threading;

namespace SHPractice_24_04_2026
{
    internal class Program
    {

        static void Task1()
        {
            int[] A = new int[10];

            var rand = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(100);
                Console.WriteLine(A[i]);
            }

            Console.Write("Введите значние: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;
            int NEven = 0;
            int He = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    He += 1;

                }
                if (A[i] % 2 != 0)
                {
                    NEven += 1;

                }
                if (A[i] != input)
                {
                    Sum += 1;

                }


            }
            Console.WriteLine("Чётных: " + He);
            Console.WriteLine("Не чётных: " + NEven);
            Console.WriteLine("Различных с вашим: " + Sum);
        }
        static void Task2()
        {
            int[] Arr = new int[10];

            int Time = 100;
            string Dot = " ";
            Console.Write("Введите значение: ");
            int U = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int Result = 0;

            var rand = new Random(0);
            
            for (int i = 0; i < Arr.Length;i++)
            {
                Arr[i] = rand.Next(100);
                Console.Write(Arr[i] + ",");

            }

            Console.WriteLine();
            for (int j = 0; j < Arr.Length; j++)
            {
                if (Arr[j] < U)
                {
                    Result += 1;
             
                }
                if (j == Arr.Length - 1)
                {
                
                    Dot = ".";
                }
                Thread.Sleep(Time);
                Console.Write("\rЗначений в массиве меньше вашего: " + Result + Dot);
            }
            Console.ReadLine();
            
        }
        static void Task3()
        {

        }

        static void Main(string[] args)
        {
            Task2();
        }
    }
}