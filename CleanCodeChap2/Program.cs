using System;

namespace CleanCodeChap2
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new GuessStatisticsMessage();
            Console.WriteLine(message.Make("backend developer", 0));
        }
    }
}
