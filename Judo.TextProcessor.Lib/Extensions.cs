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
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '\'')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
