using System;
using System.Collections.Generic;

namespace MessageProcessingApp
{
    static class MessageProcessor
    {
        public static List<string> ReadMessages()
        {
            List<string> messages = new List<string>();

            Console.WriteLine("Вводите сообщения по одному.");
            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "") break;
                    messages.Add(input);
            }

            return messages;
        }

        public static void Process(List<string> messages)
        {
            const int CheckNumber = 3;
            Func<string, bool> isLong = message => message.Length > CheckNumber;
            Func<string, string> toLog = message => "[LOG] " + message.ToUpper();

            List<string> history = new List<string>();
            Action<string> handleResult = result =>
            {
                Console.WriteLine($"Результат в верхем регистре: {result}");
                history.Add(result);
            };

            foreach (string message in messages)
                if (isLong(message))
                    handleResult(toLog(message));

            Console.WriteLine("Сохранено:");
            foreach (string savedMessage in history)
                Console.WriteLine(savedMessage);
        }
    }
}
