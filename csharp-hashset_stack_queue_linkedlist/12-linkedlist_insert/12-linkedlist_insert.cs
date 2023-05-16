using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> add = null, node = myLList.First;

        while(node != null)
        {
            if (n <= node.Value && (add == null || n > add.Value))
                return myLList.AddBefore(node,n);
            add = node;
            node = node.Next;
        }
        return myLList.AddLast(n);
    }
}
