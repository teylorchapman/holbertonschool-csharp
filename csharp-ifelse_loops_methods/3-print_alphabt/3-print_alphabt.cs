using System;

public class Alphabet
{
    public static void Main(string[] args)
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c == 'e' || c == 'q')
                continue;
            Console.Write(c);
        }
    }
}
