﻿using System;
using System.Collections.Generic;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is empty")
            return -1;
        }
        int max = myList[0];
        for (int i = 1, i < myList.Count; i++)
        {
            if (myList[i] > max)
            {
                max = myList[i];
            }
        }
        return max;
    }
}
