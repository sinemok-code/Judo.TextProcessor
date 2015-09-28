using Judo.TextProcessor.Lib;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Judo.TextProcessor.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLocation = ConfigurationManager.AppSettings["InputFileLocation"];

            var wordCounter = new WordCounter();
            var words = wordCounter.GetWords(fileLocation);

            WriteToConsole(words);

            Console.Read();
        }

        private static void WriteToConsole(WordResponse wordResponse)
        {
            var sortedWords = new SortedDictionary<string, int>(wordResponse.Words);

            Console.WriteLine("{0,-15}{1,-15}", "Word", "Count");

            foreach (var word in sortedWords)
            {
                Console.WriteLine("{0,-15}{1,-15}", word.Key, word.Value);
            }

            Console.WriteLine(Environment.NewLine + "Filtered Words");
            var filteredWordsStr = string.Join(",", wordResponse.FilteredWords);
            Console.WriteLine(filteredWordsStr);
        }
    }
}
