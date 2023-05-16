using System;
using System.Collections.Generic;

public class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int sum = -1;

        foreach (int i in myLList)
        {
            sum++;
            if (i == value)
                return sum;
        }
        return -1;
    }
}
