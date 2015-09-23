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

            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation).ToLowerInvariant()).Where(x=> !string.IsNullOrEmpty(x));

            //text = text.RemoveSpecialCharacters();
            
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
