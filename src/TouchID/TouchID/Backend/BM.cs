using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TouchID.Backend
{
    public static class BM
    {

        public static char[] uniqueChars(string text)
        {
            return text.ToCharArray().OrderBy(c => c).ToArray(); ;
        }
        public static Dictionary<Char, int> lastOccurence(string pattern, char[] charpossibility)
        {
            var lastO = new Dictionary<char, int>();

            foreach (char element in charpossibility)
            {
                lastO[element] = -1;
            }

            for (int i = 0; i < pattern.Length;i++)
            {
                lastO[pattern[i]] = i;
            }

            return lastO;
        }

        public static int bmFunction(string pattern, string text)
        {
            var lastO = new Dictionary<char, int>();
            lastO = lastOccurence(pattern,uniqueChars(text));
            int n = text.Length;
            int m = pattern.Length;
            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && pattern[j] == text[s + j])
                {
                    j--;
                }

                if (j < 0)
                {
                    return s;
                }
                else
                {
                    s += Math.Max(1, j - lastO.GetValueOrDefault(text[s + j], -1));
                }
            }


            return -1;
        }
    }
}
