using System;

///<summary>
/// IIneteractive interface
///</summary>
public interface IIneteractive
{
    void Interact();
}

///<summary>
/// IBreakable interface
///</summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>
/// ICollectable interface
///</summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary>
/// Public Abstract Class
///</summary>
public abstract class Base
{
    public string name;
    public override string ToString()
    {
         return name + " is a " + this.GetType();
    }
}

///<summary>
/// Public class
///</summary>
public class Test Object : Base, IIneteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {}

    public void Break()
    {}

    public void Collect()
    {}
}
