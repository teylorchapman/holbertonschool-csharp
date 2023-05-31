using System;

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
    public string name { get; set; }
    ///<summary> overrides a string> </summary>
    public override string ToString()
    {
         return name + " is a " + this.GetType();
    }
}

///<summary>
/// Public class
///</summary>
public class Key : Base, ICollectable
{
    ///<summary> Property </summary>
    public bool isCollected { get; set; }

    ///<summary> Constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary> Collect() Method </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}
