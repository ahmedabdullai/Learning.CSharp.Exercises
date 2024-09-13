using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class StringExtensions
    {
        public static string Shorten(this string s, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = s.Split(' ');

            if (words.Length < numberOfWords)
                return s;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
