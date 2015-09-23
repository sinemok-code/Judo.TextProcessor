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

        private static void WriteToConsole(Dictionary<string, int> words)
        {
            var sortedWords = new SortedDictionary<string, int>(words);

            Console.WriteLine("{0,-15}{1,-15}", "Word", "Count");

            foreach (var word in sortedWords)
            {
                var wordText = string.Format("{0}\t\t{1}", word.Key, word.Value);
                Console.WriteLine("{0,-15}{1,-15}", word.Key, word.Value);
            }
        }
    }
}
