using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CHPractice_03_05_2026
{
    internal class Program
    {
        
        class Fraction
        {
            private int b;
            private int a;

            public Fraction(int b, int a)
            {
                this.b = b;
                this.a = a;

            }

            public void print()
            {
                Console.WriteLine(b + "/" + a);
            }
            public static Fraction operator +(Fraction f, int value1)
            {
                int b = f.b;
                int a = f.a;

                for (int i = 1; i < value1 * f.a; i++)
                {
                    if (value1 * f.a % i == 0 && f.a % i == 0)
                    {
                        b = (value1 * f.a) + f.b / i;
                        a = f.a / i;
                        break;  
                    }
                    else
                    {
                        b = (value1 * f.a) + f.b;
                        a = f.a;
                    }
                    

                }
                return new Fraction(b, a);


            }
            public static Fraction operator -(Fraction f, int value1)
            {
                int b = f.b;
                int a = f.a;

                for (int i = 1; i < value1 * f.a; i++)
                {
                    if (value1 * f.a % i == 0 && f.a % i == 0)
                    {
                        b = (value1 * f.a) - f.b / i;
                        a = f.a / i;
                        break;
                    }
                    else
                    {
                        b = (value1 * f.a) - f.b;
                        a = f.a;
                    }


                }
                return new Fraction(b, a);


            }
            public static Fraction operator *(Fraction f, int value1)
            {
                return new Fraction(value1 * f.b, f.a);
            }
            public static Fraction operator /(Fraction f, int value1)
            {
                return new Fraction(f.a * value1, f.b);
            }
           
        }
        
        
        static void Main(string[] args)
        {
           
            int c = 10;
            double d = 1.5;

            Fraction n = new Fraction(1, 2);

            n = n / c;
            
            n.print();
            Console.ReadLine();
        }
    }
}
