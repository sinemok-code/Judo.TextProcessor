using System;
using System.Collections.Generic;
using System.IO;

namespace Judo.TextProcessor.Lib
{
    public class WordCounter
    {
        private readonly WordFilter m_wordFilter;

        public WordCounter()
        {
            this.m_wordFilter = new WordFilter();
        }

        public WordResponse GetWords(string fileLocation)
        {
            var wordResponse = new WordResponse();
            var wordsDictionary = new Dictionary<string, int>();

            var text = File.ReadAllText(fileLocation);
            
            var words = GetWordList(text);
            
            wordResponse.FilteredWords = m_wordFilter.Filter(words);
            wordResponse.Words = words.ToCountDictionary();
            
            return wordResponse;
        }
        
        private string[] GetWordList(string text)
        {
            text = text.RemoveSpecialCharacters();

            var seperator = new string[] { " ", Environment.NewLine };
            var words = text.ToLowerInvariant().Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}
