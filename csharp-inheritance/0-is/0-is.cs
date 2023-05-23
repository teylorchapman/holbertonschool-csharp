using System;

public class Obj
{
    ///<summary>
    /// obj class with IsOfTypeInt method
    ///</summary> 
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
