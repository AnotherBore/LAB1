using System;

namespace LAB1Task1
{
    public class Logic
    {
        public static bool IsDigit(int a, int j)
        {
            int i = 0;
            while (a > 0)
            {
                a = a / 10;
                i++;
            }
            if (i != j) return false;
            else return true;
        }
        public static int MaxNum(int a)
        {
            int max = 0;
            while (a > 0)
            {
                if (max < a % 10)
                {
                    max = a % 10;
                }
                a = a / 10;
            }
            return max;
        }
    }
    class Program
    {
        public static int InputWithChecks()
        {
            int a = 0;
            Console.WriteLine("Введите трехзначное число");
            bool allOK = false;
            bool log;
            while (!allOK)
            {
                log = int.TryParse(Console.ReadLine(), out a);
                if (!log)
                {
                    Console.WriteLine("Вы ввели строку");
                    continue;
                }
                log = Logic.IsDigit(a, 3);
                if (!log)
                {
                    Console.WriteLine("Данное число не подходит к требованиям");
                    continue;
                }
                else allOK = true;
            }
            return a;
        }
        public static void Main(string[] args)
        {
            int number = InputWithChecks();
            Console.WriteLine("Максимальная цифра в числе - {0}", Logic.MaxNum(number));
            Console.ReadLine();
        }
    }
}
