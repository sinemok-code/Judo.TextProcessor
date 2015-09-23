using System.Text;

namespace Judo.TextProcessor.Lib
{
    internal static class Extensions
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if(char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
