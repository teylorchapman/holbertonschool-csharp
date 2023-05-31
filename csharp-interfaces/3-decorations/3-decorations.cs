using System;

///<summary>
/// IInteractive interface
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
    public string name { get; set; }
    ///<summary> overrides a string> </summary>
    public override string ToString()
    {
         return name + " is a " + this.GetType();
    }
}

///<summary>
/// Deco class
///</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary> Public Bool </summary>
    public bool isQuestItem = false;
    ///<summary> Durability Property </summary>
    public int durability { get; set; }

    ///<summary> Constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary> Interact method </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look ath the {this.name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    ///<summary> Break() Method </summary>
    public void Break()
    {
        durability--;
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
    }
}
