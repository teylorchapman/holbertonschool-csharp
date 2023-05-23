using System;

///<summary>
///public class
///</summary>
public class Obj
{
    ///<summary>
    ///looks for if its solely a subclass
    ///</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
