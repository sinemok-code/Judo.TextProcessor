using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Judo.TextProcessor.Lib
{
    public class WordCounter
    {
        public Dictionary<string, int> GetWords(string fileLocation)
        {
            var text = File.ReadAllText(fileLocation);

            return this.GetWordsFromText(text);
        }

        private Dictionary<string, int> GetWordsFromText(string text)
        {
            var wordsDictionary = new Dictionary<string, int>();

            text = text.RemoveSpecialCharacters();
            
            var seperator = new string[] { " ", Environment.NewLine };
            var words = text.ToLowerInvariant().Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string word in words)
            {
                if (wordsDictionary.Keys.Contains(word))
                    wordsDictionary[word]++;
                else
                    wordsDictionary.Add(word, 1);
            }

            return wordsDictionary;
        }
    }
}
