using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while(s.IndexOf("()") != -1 || s.IndexOf("[]") != -1 || s.IndexOf("{}") != -1)
            {//Перебираем строку пока в ней есть пара открывающихся и закрывающихся скобок
                s = s.Replace("()", "");//Удаляем из строки пары круглых скобок
                s = s.Replace("[]", "");//Удаляем из строки пары квадратных скобок
                s = s.Replace("{}", "");//Удаляем из строки пары фигурных скобок
            }
            if (s == "")//Пройдя всю строку и удалив пары, проверяем остались ли в ней скобки. Если нет - скобочная последовательность является правильной
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadKey();
        }
    }
}
