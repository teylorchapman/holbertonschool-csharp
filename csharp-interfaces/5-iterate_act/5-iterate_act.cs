using System;
using System.Collections.Generic;

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
/// Public class that inherits from Base and IInteractive
///</summary>
public class Door : Base, IInteractive
{
    ///<summary> Constructor </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary> Door interaction </summary>
    public void Interact()
    {
        Console.WriteLine( $"You try to open the {this.name}. It's locked." );
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
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
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

///<summary>
/// New public class
///</summary>
public class RoomObjects
{
    ///<summary> Prototype </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var item in roomObjects)
        {
            if (type.ToString() == "IInteractive" && item is IInteractive)
            {
                IInteractive object = item as IInteractive;
                
                if (object != null)
                {
                    object.Interact();
                }
            }

            if (type.ToString() == "IBreakable" && item is IBreakable)
            {
                IBreakable object = item as IBreakable;

                if (object != null)
                {
                    object.Break();
                }
            }

            if (type.ToString() == "ICollectable" && item is ICollectable)
            {
                ICollectable object = item as ICollectable;

                if (object != null)
                {
                    object.Collect();
                }
            }
        }
    }
}
