using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index >= 0 && index < myLList.Count)
        {
            int currentIndex = 0;
            LinkedListNode<int> currentNode = myLList.First;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    myLList.Remove(currentNode);
                    break;
                }

                currentNode = currentNode.Next;
                currentIndex++;
            }
        }
    }
}
