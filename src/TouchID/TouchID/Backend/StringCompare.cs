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
    }
}
