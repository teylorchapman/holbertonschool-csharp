using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if(num < 0)
        {
            Console.WriteLine("{0} is negative", num);
            return;
        }
        if(num > 0)
        {
            Console.WriteLine("{0} is positive", num);
            return;
        }
        Console.WriteLine("{0} is zero", num);
    }
}
