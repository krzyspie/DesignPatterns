# This repository shows example implementation of common design patters
We have three categories of design patterns, this are: **behavioral, creational, structural**.

1. Creational
   - [Singleton](#singleton)

## Singleton
A singleton class has only one instance. The class itself is responsible for careating the instance.  
Singleton class characteristics:
- only 0 or 1 instance of a singleton class exists in the application
- the class instance is created without parameters
- the class instance is not created until something requests them (lazy instantiation)
- single, private parameterless constructor
- marked as sealed
- the instance reference is hold in a private static field
- public static method provide access to the field
