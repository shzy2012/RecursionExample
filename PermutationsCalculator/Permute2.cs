namespace PermutationsCalculator
{
    using System.Collections.Generic;
    public class Permute2
    {
        public static List<string> GetAllPermutation(string input)
        {
            var ret = new List<string>();
            AddPermutation(ret, "", input);
            return ret;
        }

        public static void AddPermutation(List<string> list, string current, string substring)
        {
            if (list == null || string.IsNullOrEmpty(substring))
            {
                return;
            }

            if (substring.Length == 1)
            {
                list.Add(current + substring);
                return;
            }

            var arr = substring.ToCharArray();
            for (var i = 0; i < arr.Length; i++)
            {
                var sub = substring.Remove(i, 1);
                var tmpCurrent = current + arr[i];
                AddPermutation(list, tmpCurrent, sub);
            }
        }

    }
}
