using System;
using System.Collections.Generic;

namespace MessageProcessingApp
{
    class Program
    {
        static void Main()
        {
            List<string> messages = MessageProcessor.ReadMessages();
            MessageProcessor.Process(messages);
        }
    }
}
