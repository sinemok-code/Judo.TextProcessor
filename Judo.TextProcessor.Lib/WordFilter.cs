using System.Collections.Generic;
using System.Linq;

namespace Judo.TextProcessor.Lib
{
    internal class WordFilter
    {
        internal string[] Filter(string[] words)
        {
            var concatWords = new List<string>();

            var possibleConcatWords = words.Distinct().Where(x => x.Length == 6);
            
            var concatWordFound = false;

            foreach (var possibleConcatWord in possibleConcatWords)
            {
                foreach (var wordPrefix in words)
                {
                    if (possibleConcatWord.StartsWith(wordPrefix))
                    {
                        foreach (var wordSuffix in words)
                        {
                            if(possibleConcatWord == wordPrefix+ wordSuffix)
                            {
                                concatWords.Add(possibleConcatWord);

                                concatWordFound = true;
                                break;
                            }
                        }
                    }

                    if (concatWordFound)
                    {
                        break;
                    }
                }

                concatWordFound = false;
            }

            return concatWords.ToArray();
        }
    }
}
