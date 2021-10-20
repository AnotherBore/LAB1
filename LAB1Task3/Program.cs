using System;

namespace LAB1Task3
{
    public class Logic
    {
        public static int ProportionOfLetters(string str)
        {
            UInt16 q = 0; //для подсчета количества букв 
            UInt16 dol = 0; // перевод в проценты
            for (int i = 0; i < str.Length; i++)//пока строка не кончится
            {
                if (char.IsLetter(str[i]))//считаем буквы
                    q++;
            }
            dol = Convert.ToUInt16(q * 100 / str.Length);//возвращаем проценты
            return dol;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input;//для ввода строки
            do
            {
                Console.WriteLine("Введите строку");
                input = Console.ReadLine();
            } while (input.Length < 1); //пока не введут строку
            Console.WriteLine("Доля букв в строке - {0}%",
                Logic.ProportionOfLetters(input)); //выводим долю букв
        }
    }
}
