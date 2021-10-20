using System;
namespace LAB1Task2
{
    public class Logic
    {
        public static string squares = ""; //заводим строку для вывода отсеченных квадратов
        public static UInt16 CuttingSquares(UInt16 a, UInt16 b)
        {          
            UInt16 count = 1; // для подсчета количества отсечений
            if (a == b) //если уже квадрат
            {
                return count;
            }
            while (a != b) // пока не разрезалось в последний раз
            {
                if (a < b) //проверяем какая сторона больше
                {
                    b -= a; //отсекаем по большей стороне
                    squares = squares + $"{count}. {a} x {a}" + "\n";//в строку вписываем кавадрат и переносим строку
                }
                else
                {
                    a -= b; 
                    squares = squares + $"{count}. {b} x {b}" + "\n";
                }

                count++;
            }
            squares = squares + $"{count}. {a} x {a}" + "\n"; //выводим последний квадрат
            return count; //возвращаем количество отрезаний
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
                    Console.WriteLine(Logic.squares); // выводим историю обрезаний
                }
                else
                {
                    Console.WriteLine("Прямоугольник будет разрезан {0} раз.", count);
                    Console.WriteLine(Logic.squares);
                }
                Console.ReadLine();
            }

        }
    }
    }
