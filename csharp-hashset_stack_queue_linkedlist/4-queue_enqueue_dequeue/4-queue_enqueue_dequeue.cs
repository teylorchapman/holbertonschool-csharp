using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}",  aQueue.Count);
        
        if (aQueue.Count > 0)
            Console.WriteLine("First item: {0}" + aQueue.Peek());
        else
            Console.WriteLine("Stack is empty");
        
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);
        if (containsSearch)
        {
            while (aQueue.Dequeue() != search)
                continue;
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
