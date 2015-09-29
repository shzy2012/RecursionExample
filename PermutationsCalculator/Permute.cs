namespace PermutationsCalculator
{
    using System;

    public class Permute
    {
        private void swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public void setper(char[] list)
        {
            int x = list.Length - 1;
            go(list, 0, x);
        }

        private void go(char[] list, int k, int maxLen)
        {
            int i;
            if (k == maxLen)
            {
                Console.Write(list);
                Console.WriteLine(" ");
            }

            else
            {
                for (i = k; i <= maxLen; i++)
                {
                    swap(ref list[k], ref list[i]);
                    var tmp = k + 1;
                    go(list, tmp, maxLen);
                    swap(ref list[k], ref list[i]);
                }
            }
        }
    }
}
