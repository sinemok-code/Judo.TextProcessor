using System.Collections.Generic;

namespace Judo.TextProcessor.Lib
{
    public class WordResponse
    {
        public Dictionary<string, int> Words { get; set; }

        public string[] FilteredWords { get; set; }
    }
}
