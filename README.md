# DesignPatters_RealWorldImplementation

## Factory Method pattern

![Alt text](https://learning.oreilly.com/api/v2/epubs/urn:orm:book:9781803242736/files/image/B18605_Figure_4.8.jpg "a title")

1. The Factory Method pattern starts with an interface that defines a common behavior or set of behaviors. In general, using interfaces is more flexible than using a base class because you aren’t limited by the inheritance rules in C. This is to say that any child class in C# may have only one parent class. Multiple class inheritance is not supported. In the case of interfaces, any class may implement as many different interfaces as are needed.

2. When we discuss the Factory Method pattern, we call the objects the factory creates products. These are the concrete products the factory will produce. They will all implement the common product interface. In practice, you don’t need to stick with the same names, as shown in the preceding diagram.

3. A factory method has a Creator class that houses the factory method itself. The Factory Method is coded to return the Product interface so that it can return any product that implements that interface. It isn’t tied to a particular abstract base class, as was the case with Kitty’s original refactor. These creators are abstract and are meant to be overridden in concrete creator subclasses. This is what provides the flexibility we need with our bicycle factory.

4. Concrete creators provide the actual concrete classes. All your creation logic will be here.