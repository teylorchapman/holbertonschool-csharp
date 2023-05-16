using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> sum = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            sum.AddLast(i);
            Console.WriteLine(i);
        }
        return sum;
    }
}
