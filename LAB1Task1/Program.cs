using System;

namespace LAB1Task1
{
    public class Logic
    {
        public static bool IsDigit(UInt16 a, UInt16 j)
        {
            UInt16 i = 0;//переменная для количества знаков
            while (a > 0)//пока не дошли до последнего символа
            {
                a = (ushort)(a / 10);
                i++;
            }
            if (i != j) return false;// если не равно количеству, заданному пользователем
            else return true;
        }
        public static UInt16 MaxNum(UInt16 a)
        {
            UInt16 max = 0; // заводим переменную под максимальную цифру
            UInt16 current;
            while (a > 0) //пока не кончилось число
            {
                current = (ushort)(a % 10);
                if (max < current) //если есть цифра больше
                {
                    max = current; 
                }
                a = (ushort)(a / 10); //сокращаем число на одну цифру
            }
            return max;
        }
    }
    class Program
    {
        public static UInt16 InputWithChecks()
        {
            UInt16 a = 0;
            Console.WriteLine("Введите трехзначное число");
            bool allOK = false; //проверка строки на соответствие
            bool log; // соответствие определенному требованию
            while (!allOK)
            {
                log = UInt16.TryParse(Console.ReadLine(), out a); // проверяем, можно ли из строки получить число
                if (!log)//если нельзя преобразовать
                {
                    Console.WriteLine("Вы ввели строку");
                    continue;
                }
                log = Logic.IsDigit(a, 3);//проверяем, является ли число трехзначным
                if (!log)// если не является
                {
                    Console.WriteLine("Данное число не подходит к требованиям");
                    continue;
                }
                else allOK = true;// если выполнены два условия, значит можно выходить из цикла
            }
            return a;//возвращаем введенное пользователем число
        }
        public static void Main(string[] args)
        {
            UInt16 number = InputWithChecks();//вводим переменную через консоль
            Console.WriteLine("Максимальная цифра в числе - {0}", Logic.MaxNum(number));//выводим максимальную цифру
            Console.ReadLine();
        }
    }
}
