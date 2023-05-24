using System;
using System.Reflection;

///<summary>
/// method that prints the available property names
///</summary>
public class Obj
{
    ///<summary>
    /// prototype
    ///</summary>
    public static void Print(object myObj)
    {
        string className = myObj.GetType().Name;

        Console.WriteLine("{0} Properties:", className);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("{0} Methods:", className);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
