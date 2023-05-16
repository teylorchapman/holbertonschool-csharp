using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= myLList.Count || n < 0)
            return 0;
        
        var currentNode = myLList.First;
        for (int i = 0; i < n; i++)
            currentNode = currentNode.Next;
        
        return currentNode.Value;
    }
}
