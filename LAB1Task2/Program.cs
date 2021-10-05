using System;
using System.Collections.Generic;

namespace LAB1Task2
{
    public class Logic
    {
        public static UInt16 CuttingSquares(UInt16 a, UInt16 b)
        {
            string squares = "";
            UInt16 count = 1;
            if (a == b)
            {
                return count;
            }
            while (a != b)
            {
                if (a < b)
                {
                    b -= a;
                    squares = squares + $"{count}. {a} x {a}" + "\n";
                }
                else
                {
                    a -= b;
                    squares = squares + $"{count}. {b} x {b}" + "\n";
                }

                count++;
            }
            squares = squares + $"{count}. {a} x {a}" + "\n";
            Console.WriteLine(squares);
            return count;
        }
        class Program
        {
            public static UInt16 InputWithChecks(string str, UInt16 j)
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
                return (UInt16)a;
            }

            static void Main(string[] args)
            {
                UInt16 a = InputWithChecks("первую сторону прямоугольника", 1);
                UInt16 b = InputWithChecks("вторую сторону прямоугольника", 1);
                UInt16 count = Logic.CuttingSquares(a, b);
                if (count == 1) Console.WriteLine("Это квадрат");
                else if ((count < 10 || count > 20) && 
                    ((count % 10 > 1) && (count % 10 < 5)))
                {
                    Console.WriteLine("Прямоугольник будет разрезан {0} раза.", count);
                }
                else Console.WriteLine("Прямоугольник будет разрезан {0} раз.", count);
                Console.ReadLine();
            }

        }
    }
    }
