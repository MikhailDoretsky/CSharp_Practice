using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Struct;
using System.Security.Cryptography.X509Certificates;


namespace SHPractice_24_04_2026
{
    internal class Program
    {
        enum ArticleType
        {
            Electronics,
            Clothing,
            Food,
            Books,
            Other
        }

        enum ClientType
        {
            Regular,
            Gold,
            Platinum,
            VIP
        }

        enum PayType
        {
            Cash,
            Card,
            Online,
            Installment
        }

        struct Article
        {
            public int Code;
            public string Name;
            public double Price;
            public ArticleType Type;
        }

        struct Client
        {
            public int Code;
            public string FullName;
            public string Address;
            public string Phone;
            public int OrderCount;
            public double TotalOrderSum;
            public ClientType Type;
        }

        struct RequestItem
        {
            public Article Product;
            public int Quantity;
        }

        struct Request
        {
            public int OrderCode;
            public Client Client;
            public DateTime OrderDate;
            public RequestItem[] Items;
            public PayType PaymentType;

            public double TotalSum
            {
                get
                {
                    double sum = 0;
                    foreach (var item in Items)
                    {
                        sum += item.Product.Price * item.Quantity;
                    }
                    return sum;
                }
            }
        }

        class Student
        {
            public string LastName;
            public string FirstName;
            public string Patronymic;
            public string Group;
            public int Age;
            private int[][] grades;

            public Student(string lastName, string firstName, string patronymic, string group, int age)
            {
                LastName = lastName;
                FirstName = firstName;
                Patronymic = patronymic;
                Group = group;
                Age = age;
                grades = new int[3][];
                grades[0] = new int[0];
                grades[1] = new int[0];
                grades[2] = new int[0];
            }







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

<<<<<<< HEAD
       
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
       
=======
        static void Task1_Module3()
        {
           
            
            Console.WriteLine("=== Задание 1: Структура Article ===\n");

            Article article = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            Console.WriteLine($"Код товара: {article.Code}");
            Console.WriteLine($"Название: {article.Name}");
            Console.WriteLine($"Цена: {article.Price:C2}");
            Console.WriteLine($"Тип: {article.Type}");
            Console.WriteLine();
        }


        public void SetProgrammingGrades(int[] programmingGrades)
        {
            grades[0] = programmingGrades;
        }

        public void SetAdministrationGrades(int[] administrationGrades)
        {
            grades[1] = administrationGrades;
        }

        public void SetDesignGrades(int[] designGrades)
        {
            grades[2] = designGrades;
        }

        public int[] GetProgrammingGrades()
        {
            return grades[0];
        }

        public int[] GetAdministrationGrades()
        {
            return grades[1];
        }

        public int[] GetDesignGrades()
        {
            return grades[2];
        }

        public double GetAverageProgrammingGrade()
        {
            if (grades[0].Length == 0) return 0;
            double sum = 0;
            foreach (int grade in grades[0]) sum += grade;
            return sum / grades[0].Length;
        }

        public double GetAverageAdministrationGrade()
        {
            if (grades[1].Length == 0) return 0;
            double sum = 0;
            foreach (int grade in grades[1]) sum += grade;
            return sum / grades[1].Length;
        }

        public double GetAverageDesignGrade()
        {
            if (grades[2].Length == 0) return 0;
            double sum = 0;
            foreach (int grade in grades[2]) sum += grade;
            return sum / grades[2].Length;
        }

        public double GetOverallAverage()
        {
            double total = 0;
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                foreach (int grade in grades[i])
                {
                    total += grade;
                    count++;
                }
            }
            return count == 0 ? 0 : total / count;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {LastName} {FirstName} {Patronymic}");
            Console.WriteLine($"Группа: {Group}, Возраст: {Age}");
            Console.WriteLine($"Средний балл по программированию: {GetAverageProgrammingGrade():F2}");
            Console.WriteLine($"Средний балл по администрированию: {GetAverageAdministrationGrade():F2}");
            Console.WriteLine($"Средний балл по дизайну: {GetAverageDesignGrade():F2}");
            Console.WriteLine($"Общий средний балл: {GetOverallAverage():F2}");
        }


   
        static void Task1_Module3()
        {
            Console.WriteLine("=== Задание 1: Структура Article ===\n");

            Article article = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            Console.WriteLine($"Код товара: {article.Code}");
            Console.WriteLine($"Название: {article.Name}");
            Console.WriteLine($"Цена: {article.Price:C2}");
            Console.WriteLine($"Тип: {article.Type}");
            Console.WriteLine();
        }

        static void Task2_Module3()
        {
            Console.WriteLine("=== Задание 2: Структура Client ===\n");

            Client client = new Client
            {
                Code = 1001,
                FullName = "Иванов Иван Иванович",
                Address = "ул. Ленина, д. 10, кв. 5",
                Phone = "+7 (999) 123-45-67",
                OrderCount = 5,
                TotalOrderSum = 15000.50,
                Type = ClientType.Gold
            };

            Console.WriteLine($"Код клиента: {client.Code}");
            Console.WriteLine($"ФИО: {client.FullName}");
            Console.WriteLine($"Адрес: {client.Address}");
            Console.WriteLine($"Телефон: {client.Phone}");
            Console.WriteLine($"Количество заказов: {client.OrderCount}");
            Console.WriteLine($"Общая сумма заказов: {client.TotalOrderSum:C2}");
            Console.WriteLine($"Тип клиента: {client.Type}");
            Console.WriteLine();
        }

        static void Task3_Module3()
        {
            Console.WriteLine("=== Задание 3: Структура RequestItem ===\n");

            Article product = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            RequestItem requestItem = new RequestItem
            {
                Product = product,
                Quantity = 3
            };

            Console.WriteLine($"Товар: {requestItem.Product.Name}");
            Console.WriteLine($"Код товара: {requestItem.Product.Code}");
            Console.WriteLine($"Цена за единицу: {requestItem.Product.Price:C2}");
            Console.WriteLine($"Количество: {requestItem.Quantity}");
            Console.WriteLine($"Общая стоимость: {requestItem.Product.Price * requestItem.Quantity:C2}");
            Console.WriteLine();
        }

        static void Task4_Module3()
        {
            Console.WriteLine("=== Задание 4: Структура Request ===\n");

            Article product1 = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            Article product2 = new Article
            {
                Code = 102,
                Name = "Футболка",
                Price = 29.99,
                Type = ArticleType.Clothing
            };

            Client client = new Client
            {
                Code = 1001,
                FullName = "Иванов Иван Иванович",
                Address = "ул. Ленина, д. 10, кв. 5",
                Phone = "+7 (999) 123-45-67",
                OrderCount = 0,
                TotalOrderSum = 0,
                Type = ClientType.Gold
            };

            RequestItem[] items = new RequestItem[]
            {
            new RequestItem { Product = product1, Quantity = 1 },
            new RequestItem { Product = product2, Quantity = 2 }
            };

            Request request = new Request
            {
                OrderCode = 5001,
                Client = client,
                OrderDate = DateTime.Now,
                Items = items,
                PaymentType = PayType.Card
            };

            Console.WriteLine($"Код заказа: {request.OrderCode}");
            Console.WriteLine($"Клиент: {request.Client.FullName}");
            Console.WriteLine($"Дата заказа: {request.OrderDate}");
            Console.WriteLine($"Форма оплаты: {request.PaymentType}");
            Console.WriteLine("Заказанные товары:");
            foreach (var item in request.Items)
            {
                Console.WriteLine($"  - {item.Product.Name}: {item.Quantity} шт. по {item.Product.Price:C2}");
            }
            Console.WriteLine($"Сумма заказа (вычисляемое свойство): {request.TotalSum:C2}");
            Console.WriteLine();
        }

        static void Task5_Module3()
        {
            Console.WriteLine("=== Задание 5: Перечисление ArticleType ===\n");

            Console.WriteLine("Типы товаров:");
            foreach (ArticleType type in Enum.GetValues(typeof(ArticleType)))
            {
                Console.WriteLine($"  {type}");
            }
            Console.WriteLine();

            Article article = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            Console.WriteLine($"Товар: {article.Name}, Тип: {article.Type}");
            Console.WriteLine();
        }

        static void Task6_Module3()
        {
            Console.WriteLine("=== Задание 6: Перечисление ClientType ===\n");

            Console.WriteLine("Типы клиентов:");
            foreach (ClientType type in Enum.GetValues(typeof(ClientType)))
            {
                Console.WriteLine($"  {type}");
            }
            Console.WriteLine();

            Client client = new Client
            {
                Code = 1001,
                FullName = "Иванов Иван Иванович",
                Address = "ул. Ленина, д. 10, кв. 5",
                Phone = "+7 (999) 123-45-67",
                OrderCount = 0,
                TotalOrderSum = 0,
                Type = ClientType.Platinum
            };

            Console.WriteLine($"Клиент: {client.FullName}, Тип: {client.Type}");
            Console.WriteLine();
        }

        static void Task7_Module3()
        {
            Console.WriteLine("=== Задание 7: Перечисление PayType ===\n");

            Console.WriteLine("Формы оплаты:");
            foreach (PayType type in Enum.GetValues(typeof(PayType)))
            {
                Console.WriteLine($"  {type}");
            }
            Console.WriteLine();

            Article product = new Article
            {
                Code = 101,
                Name = "Ноутбук",
                Price = 1500.99,
                Type = ArticleType.Electronics
            };

            Client client = new Client
            {
                Code = 1001,
                FullName = "Иванов Иван Иванович",
                Address = "ул. Ленина, д. 10, кв. 5",
                Phone = "+7 (999) 123-45-67",
                OrderCount = 0,
                TotalOrderSum = 0,
                Type = ClientType.Gold
            };

            RequestItem[] items = new RequestItem[]
            {
            new RequestItem { Product = product, Quantity = 1 }
            };

            Request request = new Request
            {
                OrderCode = 5001,
                Client = client,
                OrderDate = DateTime.Now,
                Items = items,
                PaymentType = PayType.Online
            };

            Console.WriteLine($"Заказ №{request.OrderCode}");
            Console.WriteLine($"Форма оплаты: {request.PaymentType}");
            Console.WriteLine($"Сумма: {request.TotalSum:C2}");
            Console.WriteLine();
        }

        static void Task8_Module3()
        {
            Console.WriteLine("=== Задание 8: Класс Student ===\n");

            Student student = new Student("Петров", "Петр", "Петрович", "Группа ИС-31", 20);

            student.SetProgrammingGrades(new int[] { 10, 9, 8, 10, 9 });
            student.SetAdministrationGrades(new int[] { 8, 7, 9, 8 });
            student.SetDesignGrades(new int[] { 9, 10, 9, 10, 10, 9 });

            Console.WriteLine("Массив оценок по программированию: " + string.Join(", ", student.GetProgrammingGrades()));
            Console.WriteLine("Массив оценок по администрированию: " + string.Join(", ", student.GetAdministrationGrades()));
            Console.WriteLine("Массив оценок по дизайну: " + string.Join(", ", student.GetDesignGrades()));
            Console.WriteLine();

            student.PrintInfo();
            Console.WriteLine();
        }


>>>>>>> ff7eaccf15952ddf38eb3f1cd79bc9fe98229943
        static void Main(string[] args)
        {
            Start a = new Start();
            a.Task1_ModuleStuck();
        }
    }
}