using System;
using System.Collections.Generic;

namespace NumberProcessingApp.Processing
{
    static class NumberProcessor
    {
        static Func<int, bool> isEven = number => number % 2 == 0;
        static Func<int, int> square = number => number * number;

        public static List<int> ReadNumbers()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Вводите целые числа по одному. Пустая строка — конец ввода.");
            string input = Console.ReadLine()!;
            while (input != "")
            {
                if (!int.TryParse(input, out int enteredNumber))
                    Console.WriteLine("Ошибка: введите целое число.");
                else
                    numbers.Add(enteredNumber);

                input = Console.ReadLine()!;
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
