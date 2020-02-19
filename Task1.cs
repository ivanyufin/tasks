using System;

namespace Task1
{
    class Program
    {
        /*
            Данную задачу можно решить как минимум 3-мя способами:
            1) Используя ссылки
            2) Используя указатели
            3) С помощью встроенной в класс Array функции Sort
            В данной программе реализованы первые 2 способа
            Для работы второго способа необходимо в свойствах проекта во вкладке "Сборка" разрешить небезопасный код
        */
        const int size = 10;//Определяем размер массива
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка массива, используя ссылки");
            Console.WriteLine("Исходный массив: ");
            int[] arr = new int[size];//Определяем сам массив
            Random r = new Random(DateTime.Now.Millisecond);//Создаем переменную типа Random для генерации случайных чисел, за начальное значение принимаем миллисекунды текущей секунды
            for (int i = 0; i < arr.Length; i++)//Заполняем массив псевдослучайными числами и выводим их на экран
            {
                arr[i] = r.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();//Записываем в консоль пустую строку для лучшей читаемости
            Sort(ref arr);//Передаем сгенерированный массив по ссылке
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)//Выводим отсортированный массив на экран
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Сортировка массива, используя указатели");
            unsafe//Создаем блок небезопасного кода
            {
                int* mass = stackalloc int[size];//Определяем массив, выделяя блок памяти в стеке
                int* point = mass;//Определяем указатель на этот массив
                Random rand = new Random(DateTime.Now.Millisecond);//Создаем переменную типа Random для генерации случайных чисел, за начальное значение принимаем миллисекунды текущей секунды
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < size; i++, point++)//Заполняем массив псевдослучайными числами и выводим их на экран
                {
                    *point = rand.Next(100);
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
                Sort(mass);//Вызываем функцию сортировки массива
                Console.WriteLine("Отсортированный массив: ");
                for (int i = 0; i < size; i++)//Выводим отсортированный массив на экран
                    Console.Write(mass[i] + " ");
            }
            Console.ReadKey();
        }

        static void Sort(ref int[] mass)//Функция принимает массив по ссылке
        {
            for (int i = 0; i < mass.Length; i++)//Сортируем массив методом пузырьковой сортировки
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        int mas = mass[i];
                        mass[i] = mass[j];
                        mass[j] = mas;
                    }
                }
            }
        }

        static unsafe void Sort(int* mass)//Функция принимает в качестве аргумента указатель на выделенный блок памяти(массив)
        {
            for (int i = 0; i < size; i++)//Сортируем массив методом пузырьковой сортировки
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        int mas = mass[i];
                        mass[i] = mass[j];
                        mass[j] = mas;
                    }
                }
            }
        }
    }
}
