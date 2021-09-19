using System;

namespace LAB1Task2
{
    public class Logic
    {
        public static int CuttingSquares(int a, int b)
        {
            UInt16 count = 1;
            if (a == b) Console.WriteLine("1. {0} x {1}", a, a);
            while (a != b)
            {
                if (a < b)
                {
                    b -= a; Console.WriteLine("{0}. {1} x {2}", count, a, a);
                }
                else
                {
                    a -= b; Console.WriteLine("{0}. {1} x {2}", count, b, b);
                }

                count++;
            }
            Console.WriteLine("{0}. {1} x {2}", count, a, a);
            return count;
        }
        class Program
        {
            public static int InputWithChecks(string str, int j)
            {
                int a = 0;
                Console.WriteLine("Введите {0} (минимальное число - {1})", str, j);
                bool allOK = false;
                while (!allOK)
                {
                    bool log = int.TryParse(Console.ReadLine(), out a);
                    if (!log)
                    {
                        Console.WriteLine("Вы ввели строку");
                        continue;
                    }
                    if (a < j)
                    {
                        Console.WriteLine("Вы ввели число за пределами ОДЗ");
                        continue;
                    }
                    else allOK = true;
                }
                return a;
            }

            static void Main(string[] args)
            {
                int a = InputWithChecks("первую сторону прямоугольника", 1);
                int b = InputWithChecks("вторую сторону прямоугольника", 1);
                Console.WriteLine("Прямоугольник будет разрезан на {0} квадратов."
                    , Logic.CuttingSquares(a, b));
                Console.ReadLine();
            }

        }
    }
    }
