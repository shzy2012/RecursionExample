namespace KMP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class KMP1
    {
        static void Main()
        {
            var s = "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";
            var p = "JWq2ywqwiC2QGuBY";
            var re = ViolentMatch(s, p);
        }

        public static int ViolentMatch(string s, string p)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < p.Length)
            {
                if (s[i] == p[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }
            }

            if (j == p.Length)
            {
                return i - j;
            }
            else
            {
                return -1;
            }
        }

        public static int KMPSearch(string s, string p)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < p.Length)
            {
                // 如果j = -1, 或者当前字符匹配成功（即S[i] == P[j], 都令 i++，j++
                if (j == -1 || s[i] == p[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    // 如果j != -1，且当前字符匹配失败（即S[i] != P[j]），则令 i 不变，j = next[j]      
                    // next[j]即为j所对应的next值
                    //j = next[j];
                }
            }

            if (j == p.Length)
            {
                return i - j;
            }
            else
            {
                return -1;
            }
        }

    }
}
