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
