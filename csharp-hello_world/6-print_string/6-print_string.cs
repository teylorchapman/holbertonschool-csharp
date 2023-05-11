using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        Console.WriteLine(string.Concat(str, str, str));
        Console.Writeline(str.Substring(0, 9));
        }
}
