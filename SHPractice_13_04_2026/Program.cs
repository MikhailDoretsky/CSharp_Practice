using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
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

        static void Task1_Module_2()
        {
            var rand = new Random();

            int[] A = new int[5];
            int[,] B = new int[4, 3];

            int line = B.GetLength(0);
            int Column = B.GetLength(1);

            int GlobalCount = 0;
            int GlobalProduct = 1;
            int Honest = 0;
            int NotEven = 0;


            for (int i =0, j = 0; i < line;)
            {
                B[i,j] = rand.Next(-25, 25);
                GlobalCount += B[i, j];
                GlobalProduct = GlobalProduct * B[i, j];

               

                j++;
                if (j == Column)
                {
                    i++;
                    j = 0;
                }
            }
            int maxT = B[0, 0];
            int minT = B[0, 0];

            for (int i = 0, j = 0; i < line;)
            {
                Console.Write(B[i, j] + " ");

                if (B[i, j] % 2 != 0)
                {
                    NotEven += B[i, j];
                }
                if (B[i, j] > maxT)
                {
                    maxT = B[i, j];
                }
                if (B[i, j] < minT)
                {
                    minT = B[i, j];
                }

                j++;
                if (j == Column)
                {
                    i++;
                    j = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("maximum is " + maxT);
            Console.WriteLine("minimal is " + minT + "\t");
            Console.WriteLine("Not even numbers amount is " + NotEven);


            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"\rВведите числое под индексом {i}: ");
                int input = Convert.ToInt32(Console.ReadLine());

                A[i] = input;
                GlobalCount += input;
                GlobalProduct = GlobalProduct * input;
                if (A[i] % 2 == 0)
                {
                    Honest += A[i];
                }
                
            }
            int maxD = A[0];
            int minD = A[0];
            for (int i = 0; i < A.Length; i++)
            {
               
                Console.Write(A[i] + ", ");
                if (A[i] > maxD)
                {
                    maxD = A[i];
                }
                if (A[i] < minD)
                {
                    minD = A[i];
                }



            }
            Console.WriteLine("\n" + "maximum is " + maxD);
            Console.WriteLine("minimal is " + minD);
            Console.WriteLine("Honest numbers amount is " + Honest + "\n\t");

            if (maxT == maxD)
            {

                Console.WriteLine("General maximum is " + maxT);
            }
            else
            {
                Console.WriteLine("General maximum isn't found");
            }

            if (minT == minD)
            {

        
                Console.WriteLine("General maximum is " + minT);
            }
            else
            {
                Console.WriteLine("General minimal isn't found");
            }
            Console.WriteLine("Tatal amount is " + GlobalCount);
            Console.WriteLine("Tatal product is " + GlobalProduct);


        }

        static void Task2_Module_2()
        {
            int[,] Arr = new int[5, 5];

            var rand = new Random();
            int Sum = 0;

            int Line = Arr.GetLength(0);
            int Column = Arr.GetLength(1);


            for (int i = 0, j = 0; i < Line;)
            {
                Arr[i, j] = rand.Next(-100, 100);
                Console.Write(Arr[i, j] + " ");
                j++;

                if (j == Column)
                {
                    i++;
                    j = 0;
                    Console.WriteLine();
                }
            }
            int Min = Arr[0, 0];
            int Max = Arr[0, 0];

            for (int i = 0, j = 0; i < Line;)
            {

                if (Arr[i, j] > Max)
                {
                    Max = Arr[i, j];
                }
                if (Arr[i, j] < Min)
                {
                    Min = Arr[i, j];
                }
                j++;

                if (j == Column)
                {
                    i++;
                    j = 0;

                }
            }
            int PosMax = Arr[0, 0];
            int PosMin = Arr[0, 0];






            for (int i = 0, j = 0; i < Line;)
            {

                if (Arr[i, j] == Max)
                {
                    PosMax = Arr[i, j];
                }
                if (Arr[i, j] == Min)
                {
                    PosMin = Arr[i, j];

                }


                j++;

                if (j == Column)
                {
                    i++;
                    j = 0;

                }

            }
            for (int d = 0, b = 0; d < Line;)
            {
                b++;
                if (b == Column)
                {
                    d++;
                    b = 0;
                }
                if (Arr[d, b] == PosMax)
                {
                    while(Arr[d, b] < PosMin)
                    {
                        Sum += Arr[d, b];
                    }
                }
            }

        }

        static void Task3_Module_2()
        {
            string[,] A = new string[,]
            {
                {"A", "B", "C", "D", "E", "F", "G" },
                {"H", "I", "K", "L", "M", "N", "0" },
                {"O", "P", "Q", "R", "S", "T", "U" },
                {"V", "W", "X", "Y", "Z","0","0" }
            };


            Console.WriteLine("Введите ключь: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int Line = A.GetLength(0);
            int Column = A.GetLength(1);

            int NewLine = input * Line;
            int NewColumn = input * Column;

            string[,] NA = new string[NewLine,NewColumn];

            for (int i = 0, j = 0; i < NewLine;)
            {
                NA[i, j] = "0";
                
                j++;
                if (j == NewColumn)
                {
                    i++;
                    j = 0;
                    
                }
            }
            
            for (int d = 0, b = 0,i = 0,j = input; i < NewLine - input;)
            {
                NA[i, j] = A[d, b];
                j += input;
                b++;
                if (j == NewColumn - input)
                {
                    i += input;
                    d++;
                    j = input;
                    b = 0;
                    
                }
            }
            for (int i = 0, j = 0; i < NewLine;)
            {
                
                Console.Write(NA[i, j], " ");
                j++;
                if (j == NewColumn)
                {
                    i++;
                    j = 0;
                    Console.WriteLine();
                }
            }



        }

        static void Task4_Module_2()
        {
            var rand = new Random();

            int[,] Matrix1 = new int[2, 3];

            int[,] Matrix2 = new int[2, 3];

           
            int Line1 = Matrix1.GetLength(0);
            int Column1 = Matrix1.GetLength(1);

            int Line2 = Matrix2.GetLength(0);
            int Column2 = Matrix2.GetLength(1);

            int[,] ResultMat = new int[Line1, Column1];

            for (int i = 0, j = 0; i < Line1;)
            {
                Matrix1[i, j] = rand.Next(50);
                Console.Write(Matrix1[i, j] + " ");

                j++;
                if (j == Column1)
                {
                    i++;
                    j = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Матрица 1");
            Console.WriteLine();

            for (int i = 0, j = 0; i < Line2;)
            {
                Matrix2[i, j] = rand.Next(50);
                Console.Write(Matrix2[i, j] + " ");

                j++;
                if (j == Column2)
                {
                    i++;
                    j = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Матрица 2");
            Console.WriteLine();


            Console.Write("Введите операцию: ");
            string Input = Console.ReadLine();


            if (Input == "+")
            {
                for (int i = 0, j = 0; i < Line2;)
                {
                    ResultMat[i, j] = Matrix1[i, j] + Matrix2[i, j];

                    Console.Write(ResultMat[i, j] + " ");

                    j++;
                    if (j == Column2)
                    {
                        i++;
                        j = 0;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Результат");
                Console.WriteLine();
            }
            else if (Input == "-")
            {
                for (int i = 0, j = 0; i < Line2;)
                {
                    ResultMat[i, j] = Matrix1[i, j] - Matrix2[i, j];

                    Console.Write(ResultMat[i, j] + " ");

                    j++;
                    if (j == Column2)
                    {
                        i++;
                        j = 0;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Результат");
                Console.WriteLine();
            }
            else if (Input == "/")
            {
                for (int i = 0, j = 0; i < Line2;)
                {
                    ResultMat[i, j] = Matrix1[i, j] / Matrix2[i, j];

                    Console.Write(ResultMat[i, j] + " ");

                    j++;
                    if (j == Column2)
                    {
                        i++;
                        j = 0;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Результат");
                Console.WriteLine();
            }
            else if (Input == "*")
            {
                for (int i = 0, j = 0; i < Line2;)
                {
                    ResultMat[i, j] = Matrix1[i, j] * Matrix2[i, j];

                    Console.Write(ResultMat[i, j] + " ");

                    j++;
                    if (j == Column2)
                    {
                        i++;
                        j = 0;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Результат");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Операция " + "'" + Input + "'" + "не поддерживаеться");
                Task4_Module_2();
            }

        }

        static void Task5_Module_2()
        {
            int Sum = 0;
            Console.WriteLine("Введите первое значение: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе значение: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операцию: ");
            string Input = Console.ReadLine();

            if (Input == "+")
            {
                Sum = Num1 + Num2;
                Console.WriteLine(Sum);
            }
            else if (Input == "-")
            {
                Sum = Num1 - Num2;
                Console.WriteLine(Sum);
            }
            else
            {
                Console.WriteLine("Операция " + "'" + Input + "'" + "не поддерживаеться");
            }
        }

        static void Task6_Module_2()
        {
            Console.WriteLine();

            //string input = Console.ReadLine();
            string input = "today is a good day for walking. i will try to walk near the sea";

            StringBuilder ns = new StringBuilder(input);
            char Upper = char.ToUpper(input[0]);
         
            ns[0] = Upper;
            
            input = ns.ToString();
            Console.WriteLine(input);
        }

        static void Task7_Module_2()
        {
            Console.WriteLine();

            //string InputStr = Console.ReadLine();
            string InputStr = "Well Well";
            string TabuWord = Console.ReadLine();

            int index = InputStr.IndexOf(TabuWord);
            Console.WriteLine(index);
            
            
            StringBuilder NewString = new StringBuilder();
            
        }

        static void Main(string[] args)
        {
            Task4_Module_2();
            Console.Read();
        }
    
    }
}
