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

///<summary>
/// this is a subclass thats gonna inherit from Shape
///</summary>
public class Rectangle : Shape
{
    ///<summary>
    /// These are private classes for the width and the height
    /// for the rectangle
    ///</summary>
    private int width;
    private int height;

    ///<summary>
    /// This is finding the value of the width
    ///</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    
    ///<summary>
    /// This is finding the value of the height
    ///</summary>
    public int Height
    {
        get { return height;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
}
