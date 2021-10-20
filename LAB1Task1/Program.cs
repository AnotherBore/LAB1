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
            UInt16 current = 0;
            UInt16 i;
            UInt16 max = 0; // заводим переменную под максимальную цифру
            UInt16[] array = new UInt16[3];
            for (i = 0; i < 3; i++)
            {
                array[i] = (ushort)(a % 10);
                a = (ushort)(a / 10); //сокращаем число на одну цифру
            }
            for (i = 0; i < 2; i++)
            {
                if (array[i] == array[i + 1]) continue;
                else current = 1;
            }
            if (current == 1)
            {
                foreach (UInt16 k in array)
                {
                    if (max < k) max = k;
                }
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
            UInt16 max = Logic.MaxNum(number);
            if(max > 0)
            {
                Console.WriteLine("Максимальная цифра в числе - {0}", Logic.MaxNum(number));//выводим максимальную цифру
            }
            else
            {
                Console.WriteLine("Число имеет одинаковые цифры");
            }
            Console.ReadLine();
        }
    }
}
