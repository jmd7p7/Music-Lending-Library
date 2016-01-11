using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.Utility
{
    public class StringFormatting
    {
        public static String CapitalizeAllWords(String sentence)
        {
            if (String.IsNullOrWhiteSpace(sentence) || sentence == "")
                return String.Empty;
            StringBuilder builder = new StringBuilder();
            sentence.Split(' ').ToList().ForEach(s => builder.Append(Capitalize(s)).Append(" "));
            return builder.Remove(builder.Length - 1, 1).ToString();
        }

        public static String Capitalize(String s)
        {
            if (String.IsNullOrWhiteSpace(s) || s == "")
                return String.Empty;

            if (s.Trim().Length == 1)
                return char.ToUpper(s[0]).ToString();

            return char.ToUpper(s.Trim()[0]) + s.Trim().Substring(1);
        }
    }
}
