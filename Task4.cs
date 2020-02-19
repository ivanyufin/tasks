using System;

namespace Task4
{
    class Program
    {
        /*
            Данную задачу можно решить как минимум 2-мя способами:
            1) Нахождение факториала через последовательное умножение в цикле
            2) Нахождение факториала с помощью рекурсии
            В данной программе реализованы оба способа
        */
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//Вводим исходное число
            Console.WriteLine(Fact(n));//Выводим результат, найденный с помощью последовательного перемножения
            Console.WriteLine(RecFact(n));//Выводим результат, найденный с помощью рекурсии
            Console.ReadKey();
        }

        static int Fact(int n)//Функция нахождения факториала последовательным умножением в цикле
        {
            int fact = 1;
            for (int i = n; i >= 2; i--)
                fact *= i;
            return fact;
        }

        static int RecFact(int n)//Функция нахождения факториала рекурсивным перемножением
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * RecFact(n - 1);
            }
        }
    }
}
