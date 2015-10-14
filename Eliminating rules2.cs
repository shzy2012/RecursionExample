
namespace EliminatingRules2
{
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static List<string> GetRules()
        {
            List<string> list = new List<string>();
            var word = "ABACA";
            var emptyChar = 'A';
            AddRules(list, word, emptyChar);
            return list.Distinct().ToList();
        }

        public static void AddRules(List<string> rules, string word, char emptyChar)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == emptyChar)
                {
                    list.Add(word.Remove(i, 1));
                }
            }

            list = list.Distinct().ToList();
            rules.AddRange(list);
            foreach (var item in list)
            {
                AddRules(rules, item, emptyChar);
            }
        }


        static void Main(string[] args)
        {
            var list = GetRules();
        }
    }
}
