using System;
using System.Collections.Generic;

pubic class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set 2 = new HashSet<int>(list);
        HashSet<int> sum = new List<int>();

        foreach (var common in set1)
        {
            if (set2.Contains(common))
            {
                sum.Add(common);
            }
        }

        for (int x = 0; i < common.Count -1; x++)
        {
            for (int y = x + 1; y < common.Count; y++)
            {
                if (common[y] < common[x])
                {
                    int temp = common[x]
                    common[x] = common[y];
                    common[y] = temp;

                }
            }
        }
        return common;
    }
}
