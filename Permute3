namespace PermutationsCalculator
{
    using System;

    public class Permute3
    {
        public static void Go(string prefix, string suffix)
        {
            if (string.IsNullOrWhiteSpace(suffix))
            {
                return;
            }
            if (suffix.Length == 1)  //最后一个字符
            {
                Console.WriteLine(prefix + suffix); // 处理:输出
            }

            // 转化为数组
            var charArr = suffix.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                var tmpPrefix = prefix + charArr[i]; // 添加当前字符
                var tmpSuffix = suffix.Remove(i, 1); // 移除当前字符
                Go(tmpPrefix, tmpSuffix);      // 继续执行
            }
        }


        //static void Main(string[] args)
        //{
        //    Permute3.Go(string.Empty, "ABC");
        //}
    }
}
