using System;

///<summary>
/// This is a public class
///</summary>
public class Shape
{
    ///<summary>
    /// this is gonna throw an exception
    ///</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
