# C# - Inheritance



### Learning Objectives


##### At the end of this project, you are expected to be able to explain to anyone, without the help of Google.



### General

##### * What is inheritance
##### * How polymorphism achieved with inheritance
##### * What is a base class
##### * What is a derived class
##### * How to create a derived class
##### * How to override a method or property inherited from the base class
##### * What is the difference between the ```override``` and the ```new``` modifiers 
##### * What are ```is```, ```.GetType()```, ```TypeOf()```, ```.IsInstanceOfType()```, and ```.IsSubclassOf()``` and when to use them



### Requirements

#### General
###### * Allowed editors: ```Visual Studio Code```
###### * All files will be compiled on Ubuntu 14.04 LTS using ```dotnet```
###### * A ```README.md``` file, at the root of the folder of the project, is mandatory
###### * All default C# files named ```Program.cs``` should be renamed to the name given in each task
###### * Each C# task requires its own folder and ```.csproj``` file. Push all task folders to your GitHub and ensure the task names on the folders are correct
###### * You do not need to push your ```obj/``` or ```bin/``` folders
###### * In the following examples, the ```main.cs``` files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own ```main.cs``` files at compilation. Our ```main.cs``` files might be different from the one shown in the examples
###### * All your public classes and their members should have XML documentation tags
###### * All your private classes and members should be documented but without XML documentation tags



#### Task 0: This is one of these
    
    Write a method that returns ```True``` if the object is an ```int```, otherwise return ```False```.
        * Class: ```obj```
        * Prototype: ```public static bool IsOfTypeInt(object obj)```


#### Task 1: For instance

    Write a method that returns ```True``` if the object is an instance of, or if the object is an instance of a class that inherited from ```Array```, otherwise return ```False```.
        * Class: ```obj```
        * Prototype: ```public static bool IsOfTypeInt(object obj)```



#### Task 2: Only subclass

    Write a method that returns ```True``` if the object is an instance of a class that inherits from the specified class, otherwise return ```False```. The object must be a subclass; your method cannot return ```True``` if the object is an instance of the base class.
        * Class: ```Obj```
        * Prototype: ```public static bool IsOnlyASubclass(Type derivedType, Type baseType)```



#### Task 3: Type
    
    Write a method that prints the names of the available properties and methods of an object.
        * Class: ```Obj```
        * Prototype: ```public static void Print(object myObj)```



#### Task 4: It's not a lesson in classes and inheritance without a Dog
    
    Write a empty class ```Dog``` that inherits from empty class ```Animal```.
        * Base Class: ```Animal```
        * Derived Class: ```Dog```


#### Task 5: Basic shapes
    
    Write a class ```Shape```.
        * Class: ```Shape```
            * public method: ```public virtual int Area()```
                * Throws an ```NotImplementedException``` with the message ```Area() is not implemented```


#### Task 6: Rectangle
    
    Based on ```5-shape```, write a class ```Rectangle``` that inherits from ```Shape```.
        * Class: ```Rectangle```
            * private field: ```private int width```
            * private field: ```private int height```
            * public property: ```public int Width```
                * ```get```: retreive ```width```
                * ```set```: if value is negative, throw an ```ArgumentException``` with the message ```Width must be greater than or equal to 0```. Otherwise, set ```width``` to the value.
            * public property: ```public int Height```
                * ```get```: retreive ```height```
                * ```set```: if value is negative, throw an ```ArgumentException``` with the message ```Height must be greater than or equal to 0```. Otherwise, set ```Height``` to the value.


#### Task 7: Full rectangle

    Based on ```6-shape```, write a class ```Rectangle``` that inherits from ```Shape```.
        * Class: ```Rectangle```
            * private field: ```private int width```
            * private field: ```private int height```
            * public property: ```public int Width```
                * ```get```: retreive ```width```
                * ```set```: if value is negative, throw an ```ArgumentException``` with the message ```Width must be greater than or equal to 0```. Otherwise, set ```width``` to the value.
            * public property: ```public int Height```
                * ```get```: retreive ```height```
                * ```set```: if value is negative, throw an ```ArgumentException``` with the message ```Height must be greater than or equal to 0```. Otherwise, set ```Height``` to the value.
            * public property: ```public int Area()```
                * This will override the ```Area()``` method defined in the ```Shape``` base class. Returns the area of the rectangle.
            * public method: ```public override string ToString()```
                * returns ```[Rectangle] <width> / <height>


#### Task 8: Square #1

    Based on ```7-shape```, write a class ```Square``` that inherits from ```Rectangle```
        * private field: ```private int size```
        * public property: ```public int Size```
            * ```get```: retrieve ```size```
            * set: if value is negative, throw an ```ArgumentException``` with the message ```Size must be greater than or equal to 0```. Otherwise, set ```size```, ```height```, and ```width``` to the value.



#### Task 9. Square #2
    Based on ```8-shape```, write a class ```Square``` that inherits from ```Rectangle```
        * private field: ```private int size```
        * public property: ```public int Size```
            * ```get```: retrieve ```size```
            * set: if value is negative, throw an ```ArgumentException``` with the message ```Size must be greater than or equal to 0```. Otherwise, set ```size```, ```height```, and ```width``` to the value.
        * ```Area()``` should work **without** writing a new ```Area()``` method within your ```Square``` class
        * ```.ToString()``` should return ```[Square] <size> / <size>```



#### Task 10: Liskov
    This is a blog post that I will be posting on LinkedIn to which I will link down here afterwards.