using System;

///<summary>
/// IIneteractive interface
///</summary>
public interface IIneteractive
{
    ///<summary>
    /// Interact thing
    ///</summary>
    void Interact();
}

///<summary>
/// IBreakable interface
///</summary>
public interface IBreakable
{
    ///<summary>
    /// Tests Durability
    ///</summary>
    int durability { get; set; }
    void Break();
}

///<summary>
/// ICollectable interface
///</summary>
public interface ICollectable
{
    ///<summary>
    /// Collects something
    ///</summary>
    bool isCollected { get; set; }
    void Collect();
}

///<summary>
/// Public Abstract Class
///</summary>
public abstract class Base
{
    ///<summary>
    /// This is the base class that overrides a string
    ///</summary>
    public string name;
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
    ///<summary>
    /// This is testing
    ///</summary>
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {}

    public void Break()
    {}

    public void Collect()
    {}
}
