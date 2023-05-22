# C# - Classes and Namespaces



### Learning Objectives


##### At the end of this project, you are expected to be able to explain to anyone, without the help of Google.



### General

##### * How to document C# code with XML comments
##### * What is object-oriented programming?
##### * What is a namespace
##### * What is a class
##### * What are objects and instances
##### * What is the difference between a class and an object or instance
##### * What is a field
##### * What is a constructor
##### * What is a property
##### * How to use get and set
##### * When to use a constructor and when to use a property
##### * What is this and when to use it
##### * What is a method
##### * What are access modifiers
##### * What is a static class
##### * What is a static member
##### * What is encapsulation
##### * What is polymorphism
##### * What is abstraction
##### * What does toString do and how to override it
##### * What is the difference between a class and a struct
##### * When to use a class and when to use a struct
##### * What is garbage collection in C#



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



### More Info

From this project forward, documenting your code is required!

##### * Use XML documentation comments
##### * XML Documentation Best Practices
##### * All public types / classes and their members should be documented with ```<summary>``` tags
##### * Private members should be documented but without XML comments
##### * To enable XML documentation in your project, you must add this line to the ```PropertyGroup``` in your ```.csproj``` file:
#####   * ```<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>```
##### * Compiling your project with ```/doc``` will create an XML file in the directory specified above. With the ```.xml``` in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.




#### Task 0: Braaainsss
    
    Create a new namespace ```Enemies```. Create an empty public class ```Zombie``` within ```Enemies``` that defines a zombie.


#### Task 1: Healthy competition

    Based on ```0-enemy```, wite a public class ```Zombie``` that defines a zombie by:
        * public field ```health```
        * ```health``` should be an int and have no value
        * public constructor: ```public Zombie()```
            * sets the value of ```health``` to ```0```


#### Task 2: Health validation

    Based on ```1-enemy```, wite a public class ```Zombie``` that defines a zombie by:
        * public field ```health```
        * ```health``` should be an int and have no value
        * public constructor: ```public Zombie()```
            * sets the value of ```health``` to ```0```
        * a new public constructor: ```public Zombie(int value)```
            * ```value``` must be greater than or equal to 0
            * If ```value``` is less than 0, throw an ```ArgumentException``` with the message ```Health must be greater than or equal to 0```



#### Task 3: Zombie health
    Based on ```2-enemy```, wite a public class ```Zombie``` that defines a zombie by:
        * public field ```health```
        * ```health``` should be an int and have no value
        * public constructor: ```public Zombie()```
        * sets the value of ```health``` to ```0```
        * a new public constructor: ```public Zombie(int value)```
        * ```value``` must be greater than or equal to 0
        * public method ```public int GetHealth()``` that returns the value of health of the Zombie object'''



#### Task 4:
    Based on ```3-enemy```, wite a public class ```Zombie``` that defines a zombie by:
        * public field ```health```
        * ```health``` should be an int and have no value
        * public constructor: ```public Zombie()```
        * sets the value of ```health``` to ```0```
        * a new public constructor: ```public Zombie(int value)```
        * ```value``` must be greater than or equal to 0
        * private field ```name```
        * ```name``` should be a string and have a default value of ```(No name)```
        public property ```Name```
            * ```get```: retrieve name
            * ```set```: set name
        * public method ```public int GetHealth()``` that returns the value of health of the Zombie object'''


#### Task 5:
    Based on ```3-enemy```, wite a public class ```Zombie``` that defines a zombie by:
        * public field ```health```
        * ```health``` should be an int and have no value
        * public constructor: ```public Zombie()```
        * sets the value of ```health``` to ```0```
        * a new public constructor: ```public Zombie(int value)```
        * ```value``` must be greater than or equal to 0
        * private field ```name```
        * ```name``` should be a string and have a default value of ```(No name)```
        public property ```Name```
            * ```get```: retrieve name
            * ```set```: set name
        * public method ```public int GetHealth()``` that returns the value of health of the Zombie object'''
        * public ```.toString()``` override that prints the Zombie object’s attributes to stdout
            * Format: ```Zombie Name: <name> / Total Health: <health>``` (see example below)
