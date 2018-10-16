# Zoo
## Description
This is a sample zoo hierarchy that shows the relationships between classes and derived classes using the fun backdrop of a fictional zoo made up of Crows and Crocodiles.

![Zoo Diagram](ClassDiagram.png)

## OOP Principles
### Encapsulation
The process of changing access modifiers on different classes, methods, and properties in order to protect them.
My Animal, Corvidae, and Crocodilia classes are public while my Crow, Raven, Jackdaw, Alligator, Crocodile, and Caiman classes are private.

### Polymorphism
The process of changing methods and properties on a derived class from the methods and properties in the base class. 
My Animal has abstract methods and properties that are overridden in my Corvidae and Crocodilia classes.  My Corvidae class has a virtual method that is overridden in my Raven, Crow, and Jackdaw classes. My Crocodilia class has a virtual method that is overridden by my Crocodile, Caiman and Alligator classes.

###  Abstraction
Classes, methods, and properties that are considered incomplete that are to be filled in by derived classes.
My Animal, Corvidae, and Crocodilia classes are abstract and are overridden by my Crow, Raven, Jackdaw, Alligator, Crocodile, and Caiman classes.

### Inheritance
Creating classes that are derived from a base class.  Derived classes share methods and properties with the base class.
My Animal class shares properties with my Corvidae and Crocodilia classes. My Corvidae shares a property with my Crow, Jackdaw, and Raven classes. My Crocodilia class shares a property with my Caiman, Crocodile, and Alligator classes.

## Extras
### Interface
An interface allows us to bring in methods and properties that were not directly inherited from a parent class.
For this project, I have two interfaces named ICanLayEggs and ICanDig. The ICanLayEggs interface is implemented in the following classes: Common Raven, American Crow, American Alligator, and Nile Crocodile. The ICanDig interface is implemented in the following classes: Red Kangaroo, Agile Wallaby, American Alligator, and Nile Crocodile. These interfaces are used because the methods and properties are not available for inheritance. For instance, some Austalophenids lay eggs but none of the classes I have included.  Additionally, I could have placed the ICanDig interface as a method in Animal but not all Animals can dig a hole.
