﻿using System;
using System.Collections.Generic;

public class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int i = 0;
        foreach (int y in myList)
        {
            i++;
        }
        return i;
    }
}
