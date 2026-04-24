using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SHPractice_25_04_2026
{
    internal class Program
    {

        class ClassOfTask4
        {
            private string Name;
            private string Url;
            private string Descr;
            private string ip;

            public void SetName(string value)
            {
                Name = value;
            }
            public void SetDecr(string value)
            {
                Descr = value;
            }
            public void PrinrAll()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Url);
                Console.WriteLine(Descr);
                Console.WriteLine(ip);
            }
            public ClassOfTask4(string valueUrl, string valueIp)
            {
                Url = valueUrl;
                ip = valueIp;
            }

        }

        class ClassOfTask5
        {
            private string Name;
            private string MakeAge;
            private string ContactNumber;
            private string ContactEmail;
            private string Descr;

            public void SetName(string value)
            {
                Name = value;
            }
            public void SetDecr(string value)
            {
                Descr = value;
            }
            public void SetContactNumber(string value)
            {
                ContactNumber = value;
            }
            public void SetContactEmail(string value)
            {
                ContactEmail = value;
            }

            public void SetMakeAge(string value)
            {
                MakeAge = value;
            }
            public void PrinrAll()
            {
                Console.WriteLine(Name);
                Console.WriteLine(ContactNumber);
                Console.WriteLine(ContactEmail);
                Console.WriteLine(Descr);
                Console.WriteLine(MakeAge);
            }


        }

        class ClassOfTask6
        {
            private string Name;
            private string Adress;
            private string ContactNumber;
            private string ContactEmail;
            private string Descr;


            public void SetName(string value)
            {
                Name = value;
            }
            public void SetDecr(string value)
            {
                Descr = value;
            }
            public void SetAdress(string value)
            {
                Adress = value;
            }
            public void SetContactNumber(string value)
            {
                ContactNumber = value;
            }
            public void SetContactEmail(string value)
            {
                ContactEmail = value;
            }
            public void PrinrAll()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Adress);
                Console.WriteLine(ContactNumber);
                Console.WriteLine(ContactEmail);
                Console.WriteLine(Descr);

            }


        }



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

        static void Task3_Module3()
        {

            static int[] FilterArray(int[] originalArray, int[] filterArray)
            {
                HashSet<int> filterSet = new HashSet<int>(filterArray);
                List<int> result = new List<int>();

                foreach (int item in originalArray)
                {
                    if (!filterSet.Contains(item))
                    {
                        result.Add(item);
                    }
                }

                return result.ToArray();
            }

            static void Main()
            {
                int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
                int[] filterArray = { 6, 88, 7 };

                int[] result = FilterArray(originalArray, filterArray);

                Console.WriteLine("Оригинальный массив: " + string.Join(", ", originalArray));
                Console.WriteLine("Массив для фильтрации: " + string.Join(", ", filterArray));
                Console.WriteLine("Результат: " + string.Join(", ", result));
            }

        }

        static void Task4_Module3()

        

        static void Task5_Module3()
        {
            ClassOfTask5 o = new ClassOfTask5();
            o.SetName("Journal");
            o.PrinrAll();
        }

        static void Task6_Module3()
        {
            ClassOfTask6 o = new ClassOfTask6();
            o.SetName("Shop");
            o.PrinrAll();
        }

       

        static void Main(string[] args)
        {
            //Task1_Module3();
            //Task2_Module3();
            //Task4_Module3();
            //Task5_Module3();
            //Task6_Module3();
            Task7_Module3();

        }
        
}
