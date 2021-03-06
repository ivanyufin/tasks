﻿using System;

namespace Task2
{
    class Program
    {
        /*
            Данную задачу можно решить множеством способов, например:
            1) Последовательный поиск
            2) Бинарный поиск
            3) Поиск с помощью встроенной в класс Array функции BinarySearch
            В данной программе реализован 2 способ, то есть бинарный поиск
        */
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//Определяем исходный отсортированный по возрастанию массив
            int left = 0, right = arr.Length - 1, search = -1, key = 0;//Определяем необходимые переменный
            /*left - левая граница поиска, right - правая граница поиска, mid - середина отрезка между left и right,
              search - индекс (не)найденного числа, key - искомое число
            */
            key = Convert.ToInt32(Console.ReadLine());//Вводим искомое число
            while(left <= right)//Поиск будет продолжаться пока левая граница не дойдет до правой
            {
                int mid = (left + right) / 2;//Вычисляем середину отрезка
                if (key == arr[mid])//Если искомое число соответствует числу в массиве на позиции с индексом mid
                {
                    search = mid;//То мы нашли искомое число. Запоминаем его индекс и прекращаем поиск
                    break;
                }
                if (key < arr[mid])//Если искомое число меньше числа в массиве на позиции с индексом mid, то "двигаем" правую границу
                    right = mid - 1;
                else//Иначе "двигаем" левую границу
                    left = mid + 1;
            }
            if (search == -1)//Если после поиска переменная search не изменилась, то ничего не найдено
                Console.WriteLine("Искомое число не найдено");
            else
                Console.WriteLine("Искомое число найдено на позиции: " + search);
            Console.ReadKey();
        }
    }
}
