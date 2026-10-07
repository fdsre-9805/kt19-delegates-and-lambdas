static class InputReader
{
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
}
