using System;

///<summary>
/// IIneteractive interface
///</summary>
public interface IInteractive
{
    ///<summary> Interact method </summary>
    void Interact();
}

///<summary>
/// IBreakable interface
///</summary>
public interface IBreakable
{
    ///<summary> Property </summary>
    int durability { get; set; }
    ///<summary> Break Method </summary>
    void Break();
}

///<summary>
/// ICollectable interface
///</summary>
public interface ICollectable
{
    ///<summary> Property </summary>
    bool isCollected { get; set; }
    ///<summary> Collect method </summary>
    void Collect();
}

///<summary>
/// Public Abstract Class
/// </summary>
public abstract class Base
{
    ///<summary> This is the base class that overrides a string </summary>
    public string name;
    ///<summary> overrides a string> </summary>
    public override string ToString()
    {
         return name + " is a " + this.GetType();
    }
}

///<summary>
/// Public class
///</summary>
public class TestObject : Base, IIneteractive, IBreakable, ICollectable
{
    ///<summary> This is testing </summary>
    public int durability { get; set; }
    ///<summary> Bool </summary>
    public bool isCollected { get; set; }

    ///<summary> Interact method </summary>
    public void Interact()
    {}

    ///<summary> Break method </summary>
    public void Break()
    {}

    ///<summary> Collect method </summary>
    public void Collect()
    {}
}
