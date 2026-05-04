using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Struct;
using System.Security.Cryptography.X509Certificates;


namespace SHPractice_24_04_2026
{
    internal class Program
    {

        static void Task1_Module2()
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
        static void Task2_Module2()
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
        static void Task3_Module2()
        {
            int[] Arr = new int[13] {7,6,5,1,2,3,7,6,5,1,7,6,5};
            int[] Nums = new int[3];

            var rand = new Random(0);

            int Result = 0;
            bool res = true;
            while (res)
            {
                Console.Write(":  ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input / 100 != 0)
                {
                    for (int i = 0, j = 0; i < Arr.Length; i++)
                    {
                        //Arr[i] = rand.Next(100);



                        if (j == 0)
                        {
                            Nums[j] = input / 100;
                            j++;
                        }
                        if (j == 1)
                        {
                            Nums[j] = (input % 100) / 10;
                            j++;
                        }

                        if (j == 2)
                        {
                            Nums[j] = input % 10;
                            j++;
                        }
                        Console.Write(Arr[i] + " ");

                    }
                    Console.WriteLine();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        if (Arr[i] == Nums[0] && Arr[i + 1] == Nums[1] && Arr[i + 2] == Nums[2])
                        {
                            Result += 1;

                        }
                    }
                    Console.WriteLine(Result);
                    Console.ReadLine();
                    res = false;
                }
                else
                {
                    Console.Write("Ваше число не трех значное");
                    continue;

                }
            }            

        }
        static void Task4_Module2()
        {
          
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 2, 3 };
            int[] array2 = { 3, 4, 5, 8, 9, 10, 3, 4 };

            Console.WriteLine("Первый массив: " + string.Join(", ", array1));
            Console.WriteLine("Второй массив: " + string.Join(", ", array2));

           
            //int[] commonElements = array1.Intersect(array2).ToArray();

            //Console.WriteLine("Общие элементы без повторений: " + string.Join(", ", commonElements));
            //Console.WriteLine("Количество общих элементов: " + commonElements.Length);
        }

        static void Task5_Module2()
        {
         
            int[,] matrix = {
            { 5, 12, 8, 3 },
            { 19, 2, 7, 11 },
            { 4, 15, 1, 9 }
        };

            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minValue = matrix[0, 0];
            int maxValue = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minValue)
                        minValue = matrix[i, j];
                    if (matrix[i, j] > maxValue)
                        maxValue = matrix[i, j];
                }
            }

            Console.WriteLine($"Минимальное значение: {minValue}");
            Console.WriteLine($"Максимальное значение: {maxValue}");
        }
       
        static void Task6_Module2()
        {
           
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Вы не ввели предложение.");
                return;
            }

           
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' },
                                            StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Количество слов в предложении: {words.Length}");
        }
       
        static void Task7_Module2()
        {

            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Вы не ввели предложение.");
                return;
            }

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' },
                                            StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Результат переворота: ");
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);
                Console.Write(reversedWord);

                if (i < words.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();

        }
        
        static void Task8_Module2()
        {
            

            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Вы не ввели предложение.");
                return;
            }

           
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                          'a', 'e', 'i', 'o', 'u', 'y' };

            int vowelCount = 0;
            string lowerSentence = sentence.ToLower();

            foreach (char c in lowerSentence)
            {
                if (Array.IndexOf(vowels, c) != -1)
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Количество гласных букв в предложении: {vowelCount}");
        }
      
        static void Task9_Module2()
        {

            Console.Write("Введите исходную строку: ");
            string text = Console.ReadLine();

            Console.Write("Введите подстроку для поиска: ");
            string substring = Console.ReadLine();

            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(substring))
            {
                Console.WriteLine("Строка или подстрока не могут быть пустыми.");
                return;
            }

            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += substring.Length;
            }

            Console.WriteLine($"Подстрока \"{substring}\" встречается {count} раз(а)");

          
            Console.WriteLine("\nПример из задания:");
            string exampleText = "Why she had to go. I don't know, she wouldn't say";
            string exampleSubstring = "she";
            int exampleCount = 0;
            int exampleIndex = 0;

            while ((exampleIndex = exampleText.IndexOf(exampleSubstring, exampleIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                exampleCount++;
                exampleIndex += exampleSubstring.Length;
            }

            Console.WriteLine($"Исходная строка: \"{exampleText}\"");
            Console.WriteLine($"Подстрока для поиска: \"{exampleSubstring}\"");
            Console.WriteLine($"Результат поиска: {exampleCount}");
        }

       
 public class SevenMiracles
        {
            protected string MakeDate;
            protected string Name;
        
            public SevenMiracles(string value1, string value2)
            {
                string MakeDate = value1;
                string Name = value2;
            }
            public void Print() 
            { 
                Console.WriteLine()
            }

        }
public class Start : SevenMiracles
        {
            public void Task1_ModuleStuck()
            {
                var One = new SevenMiracles("3rd century BC", "Pyramid of Cheops")
                One.Print();
            }
        }
       
        static void Main(string[] args)
        {
            Start a = new Start();
            a.Task1_ModuleStuck();
        }
    }
}