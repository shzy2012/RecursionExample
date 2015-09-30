namespace PermutationsCalculator
{
    using System;

    public class Permute4
    {
        /// <summary>
        /// 交换
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void swap(ref char a, ref char b)
        {
            if (a == b) return;
            var tmp = a;
            a = b;
            b = tmp;
        }

        public static void Go(char[] charList, int index)
        {
            if (index == charList.Length)  //结束条件
            {
                Console.Write(charList);  //处理: 输出
                Console.WriteLine(string.Empty);//换行
                return;
            }
            int i;
            for (i = index; i < charList.Length; i++)
            {
                swap(ref charList[index], ref charList[i]);
                Go(charList, index + 1);
                swap(ref charList[index], ref charList[i]);
            }
        }

        static void Main(string[] args)
        {
            Permute4.Go("ABC".ToCharArray(), 0);
        }
    }
}
