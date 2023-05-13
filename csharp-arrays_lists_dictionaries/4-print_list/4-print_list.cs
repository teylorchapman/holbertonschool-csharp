﻿using System;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> lt = new List<int>();
        for (int i = 0; i < size; i++)
        {
            lt.Add(i);
            Console.Write(i + (i != size -1 ? "" : " "));
        }
        Console.WriteLine();
        return lt;
    }
}
