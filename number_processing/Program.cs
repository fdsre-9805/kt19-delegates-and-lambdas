using System;
using System.Collections.Generic;

namespace NumberProcessingApp
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = NumberProcessor.ReadNumbers();
            NumberProcessor.Process(numbers);
        }
    }
}
