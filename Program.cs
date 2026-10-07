List<int> numbers = InputReader.ReadNumbers();

Func<int, bool> isEven = number => number % 2 == 0;
Func<int, int> square = number => number * number;

List<int> savedResults = new List<int>();
Action<int> printResult = result => Console.WriteLine($"Результат: {result}");
Action<int> saveResult = result => savedResults.Add(result);

Action<int> handleResult = printResult;
handleResult += saveResult;

foreach (int number in numbers)
{
    if (isEven(number))
    {
        handleResult(square(number));
    }
}

Console.WriteLine("Сохранено:");
foreach (int savedResult in savedResults)
{
    Console.WriteLine(savedResult);
}
