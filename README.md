# DesignPatters_RealWorldImplementation

## Factory Method pattern

![Alt text](https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781803242736/files/image/B18605_Figure_4.8.jpg "Factory Method Pattern")

1. The Factory Method pattern starts with an interface that defines a common behavior or set of behaviors. In general, using interfaces is more flexible than using a base class because you aren’t limited by the inheritance rules in C. This is to say that any child class in C# may have only one parent class. Multiple class inheritance is not supported. In the case of interfaces, any class may implement as many different interfaces as are needed.

2. When we discuss the Factory Method pattern, we call the objects the factory creates products. These are the concrete products the factory will produce. They will all implement the common product interface. In practice, you don’t need to stick with the same names, as shown in the preceding diagram.

3. A factory method has a Creator class that houses the factory method itself. The Factory Method is coded to return the Product interface so that it can return any product that implements that interface. It isn’t tied to a particular abstract base class, as was the case with Kitty’s original refactor. These creators are abstract and are meant to be overridden in concrete creator subclasses. This is what provides the flexibility we need with our bicycle factory.

4. Concrete creators provide the actual concrete classes. All your creation logic will be here.


## Abstract Factory pattern

This pattern is designed to create objects that are related and to decouple those objects from the client's dependency on a concrete type.

When we find a problem that involves families or related objects, we should automatically think about the abstract factory pattern.

A second benefit of this pattern is that it decouples the client's dependency on any particular concrete object.

![Alt text](https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781803242736/files/image/B18605_Figure_4.11.jpg "Abstract Factory Pattern 1")

1. The client is whatever code consumes the objects created by the Abstract Factory (like a property of the client object).

2. The client is dependent on the **AbstractFactory** interface. This interface defines two methods. The interface is going to refer to a pair of abstract classes.
The final product created by the Abstract Factory will be a concrete class that inherits from one of these abstract classes.

3. Two concrete factories are presented for each family of products. Our requirement have four families of products, but this diagram only shows two to keep things
simple. We can add as many concrete factories we need.

4. Two abstract classes are used to define two types of objects, independent of the family for the concrete object.

5. The final concrete products inherit from the abstract products. Each physical factory should make the frames and handlebars that are needed.

![Alt text](https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781803242736/files/image/B18605_Figure_4.12.jpg "Abstract Factory Pattern 1")