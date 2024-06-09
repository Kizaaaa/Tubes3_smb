using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchID.Backend
{
    public static class KMP
    {

        public static int[] borderFunction(string pattern)
        {
            int m = pattern.Length;
            int[] border = new int[m];
            int j = 0;
            int i = 1;
            border[0] = 0;
            while (i < m){
                if (pattern[j] == pattern[i]) {
                    border[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0){
                    j = border[j - 1];
                }
                else{
                    border[i] = 0;
                    i++;
                }
            }
            return border;
        }

        public static int kmpFunction(string pattern,string text)
        {
            int n = text.Length;
            int m = pattern.Length;
            int[] b = borderFunction(pattern);
            int i = 0;
            int j = 0;

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    if (j == m - 1){
                        return i - m + 1;
                    } 
                    i++;
                    j++;
                }
                else if (j > 0)
                    j = b[j - 1];
                else
                    i++;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            string pattern = "ABABAC";
            string text = "ABABABCDADABABACBD";

            int[] borderresult = borderFunction(pattern);
            int resultsearch = kmpFunction(pattern, text);
            Console.WriteLine($"Pattern: {pattern}");
            Console.Write("Border function: ");
            foreach (int value in borderresult)
            {
                //Console.Write(value + " ");
            }
        }
    }   
}
