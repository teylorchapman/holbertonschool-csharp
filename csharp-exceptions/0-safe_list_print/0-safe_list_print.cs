using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int elementsPrinted = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                elementsPrinted++;
            }
        }
        catch (Exception)
        {
            ;
        }
        return elementsPrinted;
    }
}
