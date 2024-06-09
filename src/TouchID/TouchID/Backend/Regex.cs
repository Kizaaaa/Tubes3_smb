using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchID.Backend
{
    public static class RegEx
    {
        public static string regexNoVowel(string nama, string[] names)
        {
            string patternNama = @"\b" + Regex.Escape(nama) + @"\b";

            foreach (string entry in names)
            {
                if (Regex.IsMatch(entry, patternNama, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(entry);
                    return entry;
                }
            }
            return null;
        }
    }
}
