using System;

namespace LAB1Task3
{
    public class Logic
    {
        public static int ProppercentageOfLetters(string str)
        {
            UInt16 q = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    q++;
            }
            int dol = q * 100 / str.Length;
            return dol;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            Logic.ProppercentageOfLetters(input);
            Console.WriteLine("Доля букв в строке - {0}%",
                Logic.ProppercentageOfLetters(input));

        }
    }
}
