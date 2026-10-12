using System;
using System.Collections.Generic;

namespace NumberProcessingApp
{
    static class NumberProcessor
    {
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
                    int enteredNumber = int.Parse(input);
                    if (enteredNumber > 10000)
                        Console.WriteLine("Ошибка: число не должно быть больше 10000.");
                    else
                        numbers.Add(enteredNumber);
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
            Func<int, bool> isEven = number => number % 2 == 0;
            Func<int, int> square = number => number * number;
            
            List<int> savedResults = new List<int>();
            Action<int> handleResult = result =>
            {
                Console.WriteLine($"Результат четного числа в квадрате : {result}");
                savedResults.Add(result);
            };

            foreach (int number in numbers)
                if (isEven(number))
                    handleResult(square(number));

            Console.WriteLine("Сохранено:");
            foreach (int savedResult in savedResults)
                Console.WriteLine(savedResult);
        }
    }
}
