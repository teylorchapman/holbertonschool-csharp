using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myDict.Count == 0)
        {
            return "None";
        }

        string maxkey = null;
        int maxvalue = -1;

        foreach (var pair in myDict)
        {
            if (pair.Value > maxvalue)
            {
                maxvalue = pair.Value;
                maxkey = pair.Key;
            }
        }
        return maxkey;
    }
}
