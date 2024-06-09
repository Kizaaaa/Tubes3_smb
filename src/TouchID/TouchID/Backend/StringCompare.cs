using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchID.Backend
{
    public static class StringCompare
    {
        public static int hammingDistance(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return -1;
            }

            int distance = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    distance++;
                }
            }

            return distance;
        }

        public static string tingkatKemiripan(string s1, string s2){
            int l1 = s1.Length;
            int l2 = s2.Length;

            if (l1>l2){
                l1=l2;
                int hd = hammingDistance(s1.Substring(0,l2),s2);
                float result = (l2 - hd) / l2;
            }
            if (l1<l2){
                l2=l1;
                int hd = hammingDistance(s1,s2.Substring(0,l1));
                float result = (l1 - hd) / l1;
            }

            
            return (String.Format("{0:F2}%", result*100));
        }
    }
}
