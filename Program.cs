﻿namespace Lesson_8_Arrays //Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // красота требует покрасти текста консоли)
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // одномерный массив чисел. Создание и инициализация
            int[] массивЧисел = { 50, 22, 30, 50, 70 };
            Console.WriteLine($"Обычный массив чисел: {массивЧисел[1]}");

            //одномерный массив строк. Создание и инициализация массива
            string[] массивСлов = { "привет", "пока", "До свидания" };
            Console.WriteLine($"Обычный массив строк: {массивСлов[1]}");

            // вывод на консоль всех элементов массива
            Console.WriteLine($"Все элементы массива: {string.Join(", ", массивЧисел)}");

            // двумерный массив
            int[,] двумерныйМассив = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };
            Console.WriteLine($"Элементы двумерного массива: {двумерныйМассив[2, 1]}");

            // Создаём зубчатый массив, состоящий из трёх массивов строк
            string[][] зубчатыйМассив = new string[3][];

            // Инициализируем каждый внутренний массив
            зубчатыйМассив[0] = new string[] { "Аня", "Борис", "Виктория" };
            зубчатыйМассив[1] = new string[] { "Григорий", "Денис" };
            зубчатыйМассив[2] = new string[] { "Елена", "Федор", "Георгий", "Дмитрий" };

            // Выводим все элементы массива, объединяя их в одну строку
            Console.WriteLine($"\nВсе элементы зубчатого массива: \n{string.Join("\n", зубчатыйМассив.Select(внутреннийМассив => string.Join(", ", внутреннийМассив)))}\n");
            
            Console.WriteLine($"Элемент конкретного массива: {string.Join(", ", зубчатыйМассив[2][3])}");

            // Получаем количество элементов в массиве
            int length = массивЧисел.Length;
            Console.WriteLine($"Количество элементов в массиве: {length}");

            // Вывод скопированных элементов
            int[] новыйМассив = new int[3];
            Array.Copy(массивЧисел, 1, новыйМассив, 0, 3);
            Console.WriteLine($"Вывод скопированных элементов: {string.Join(", ", новыйМассив)}");

            // Выводит индекса элемента
            int индексМассива = Array.IndexOf(массивЧисел, 50);
            Console.WriteLine($"Вывод индекса массива: {индексМассива}");

            // Выводит индекс последнего вхождения элемента
            int обратныйИндексМассива = Array.LastIndexOf(массивЧисел, 50);
            Console.WriteLine($"Вывод обратного индекса массива: {обратныйИндексМассива}");

            Console.ReadKey();
        }
    }
}