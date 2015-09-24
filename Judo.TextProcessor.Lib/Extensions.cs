using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Judo.TextProcessor.Lib
{
    internal static class Extensions
    {
        internal static string RemoveSpecialCharacters(this string str)
        {
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        internal static Dictionary<T, int> ToCountDictionary<T>(this T[] array)
        {
            var groups = array.GroupBy(s => s).Select(s => new { Key = s.Key, Count = s.Count() });
            var dictionary = groups.ToDictionary(g => g.Key, g => g.Count);

            return dictionary;
        }
    }
}
