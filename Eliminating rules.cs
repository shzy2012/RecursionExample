using System;
using System.Collections.Generic;
using System.Linq;

public class EliminatingRules
{
    public static void Main()
    {
        var list = GetResult("AbcAdAA", 'A').OrderBy(x => x).Distinct();
        foreach (var e in list)
        {
            Console.WriteLine(e);
        }
    }

    public static List<string> GetResult(string current, char emptyLetter)
    {
        var resultList = new List<string>();
        AddResult(resultList, current, emptyLetter);
        return resultList;
    }

    public static void AddResult(List<string> resultList, string current, char emptyLetter)
    {
        int startIndex = 0;
        List<string> subList = new List<string>();
        while (startIndex <= current.Length)
        {
            startIndex = current.IndexOf(emptyLetter, startIndex);
            if (startIndex == -1)
            {
                break;
            }

            subList.Add(current.Remove(startIndex++, 1));
        }

        resultList.AddRange(subList);

        foreach (var sub in subList.Distinct().ToList())
        {
            AddResult(resultList, sub, emptyLetter);
        }
    }
}
