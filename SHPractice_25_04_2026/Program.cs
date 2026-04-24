using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SHPractice_25_04_2026
{
    internal class Program
    {
        
        static void Task1_Module3()
        {
            Console.Write("Введите длинну: ");
            int Length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ширину: ");
            int Height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите символ: ");
            string Symbol = Console.ReadLine();

            for (int i = 0, j = 0; j < Height;)
            {
                Console.Write(Symbol + " ");
                i++;
                if (i == Length)
                {
                    j++;
                    Console.WriteLine();
                    i = 0;
                }
            }
        }

        static void Task2_Module3()
        {
            Console.Write("Введите число: ");
            string Value = Console.ReadLine();
            int Size = Value.Length;
            int Count = 0;

            for (int i = 0, j = Size; i < j; i++, j--)
            {
                
                
                if (Value[i] == Value[j - 1])
                {
                    Count++;
                }

            }
            if (Count == (Size / 2))
            {
                Console.WriteLine("Число полиморф!");
           
            }
            else
            {
                Console.WriteLine("Число не полиморф!");
              
            }
        }


        static void Main(string[] args)
        {
            //Task1_Module3();
            Task2_Module3();
        }
    }
}
