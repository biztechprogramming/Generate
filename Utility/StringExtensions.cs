using System.Globalization;

namespace Generate.Utility
{
    public static class StringExtensions
    {
        public static string ToProperCase(this string text)
        {
            var words = text.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            var result = "";
            foreach (var word in words)
            {
                if (word == "BT") continue;
                var firstLetter = word[0].ToString().ToUpper();
                var restOfWord = word.Substring(1).ToLower();
                result += firstLetter + restOfWord;
            }
            return result.Trim();
        }
    }
}