using System;
using System.Collections.Generic;

public class spongebox
{
    public static void Main(String[] args)
    {
        int[] myArray = new int[5, 5];
        myArray[2, 2] = 1;
        for (int i = 0; i < 5; i++)
        {
            for(int = 0; j < 5; j++)
            {
                Console.Write(myArray[i, j]);
                if (j < 4)
                    Console.Write(" ");
            }
            Console.Write();
        }
    }
}
