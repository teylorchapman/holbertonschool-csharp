﻿using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == NULL || myLList.Count == 0)
            return 0;
        
        int i = myLList.First.Value;
        myLList.RemoveFirst();
    }
}
