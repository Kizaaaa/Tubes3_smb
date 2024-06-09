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
            string patternNama = numberIntoVowel(nama);
            patternNama = @"\b" + Regex.Escape(nama) + @"\b";

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

        public static string numberIntoVowel(string nama)
        {
            nama = Regex.Replace(nama, "0", "o");
            nama = Regex.Replace(nama, "1", "i");
            nama = Regex.Replace(nama, "3", "e");
            nama = Regex.Replace(nama, "4", "a");
            nama = Regex.Replace(nama, "6", "g");
            return nama;
        }   
    }
}
