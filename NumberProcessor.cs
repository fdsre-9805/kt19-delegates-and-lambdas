using System;
using System.Collections.Generic;

namespace NumberProcessingApp
{
    static class NumberProcessor
    {
        static Func<int, bool> isEven = number => number % 2 == 0;
        static Func<int, int> square = number => number * number;

        public static List<int> ReadNumbers()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Вводите целые числа по одному.");
            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "") break;

                try
                {
                    numbers.Add(int.Parse(input));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
            }

            return numbers;
        }

        public static void Process(List<int> numbers)
        {
            List<int> savedResults = new List<int>();
            Action<int> printResult = result => Console.WriteLine($"Результат: {result}");
            Action<int> saveResult = result => savedResults.Add(result);

            Action<int> handleResult = printResult;
            handleResult += saveResult;

            foreach (int number in numbers)
                if (isEven(number))
                    handleResult(square(number));

            Console.WriteLine("Сохранено:");
            foreach (int savedResult in savedResults)
                Console.WriteLine(savedResult);
        }
    }
}
