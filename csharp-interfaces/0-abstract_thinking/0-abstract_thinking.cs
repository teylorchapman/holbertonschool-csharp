using System;

///<summary>
/// This is a public abstract class
///</summary>
public abstract class Base
{
    ///<summary>
    /// Public Property
    ///</summary>
    public string name;

    ///<summary> 
    /// Method that will override and return a string
    ///</summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}
