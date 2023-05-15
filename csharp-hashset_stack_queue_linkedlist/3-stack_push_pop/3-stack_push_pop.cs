using System;
using System.Collections.Generic;

public class MyStack
{
    //is it comments thats making this thing angy??
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        //print count
        Console.WriteLine("Number of items: {0}" + aStack.Count);

    
        //prints whether or not the stack is empy
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}" + aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
    

        //print if exsist
        bool containsSearch = aStack.Contains(search);
            Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

        //pop, lock, and drop it
        if (containsSearch)
        {
            while (aStack.Pop() != search)
                continue;
        }
        //ah ssss push it
        aStack.Push(newItem);
        return aStack;
    }
}
