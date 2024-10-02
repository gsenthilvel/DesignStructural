## Adapter Pattern

### What
Adapter structural design pattern is a bridge between two incompatible interfaces by converting 
the interface of a class into another interface that a client expects. It is useful when 
integrating legacy components with new systems or when creating a reusable library.


### Who

It has four key actors (1) Target Interface (2) Adapter (3) Adaptee (4) Client.

1. Target interface is the common interface that the client code interacts with.
2. Adapter is a bridge to adapt the interface of the adaptee to match the target interface.
3. Adaptee is existing system with an incompatible interface to be integrated into new system
4. Client is unaware of the specific implementation of the adaptee and the adapter.

### How

Adapter implements the ITarget interface and translates request method to the 
SpecificRequest method of the Adaptee. The client code interacts with the adapter.

```csharp


// Target Interface
public interface ITarget
{
    string Request();
}

// Adaptee
public class Adaptee
{
    public string SpecificRequest()
    {
        return "Adaptee's specific request";
    }
}

// Adapter
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string Request()
    {
        return _adaptee.SpecificRequest();
    }
}

// Client
public class Client
{
    public void Execute(ITarget target)
    {
        Console.WriteLine(target.Request());
    }
}

// Usage
class Program
{
    static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget adapter = new Adapter(adaptee);

        Client client = new Client();
        client.Execute(adapter);
    }
}

```

### Why

Reusability: Allows the reuse of existing client code with new systems.
Decoupling: Decouples the client from the specific implementation of the payment gateways.
Flexibility: Makes it easy to switch between different implementations without modifying the client code.

### When

When you need to use an existing class but its interface is not compatible with the rest of your code.

When you want to create a reusable class that can work with unrelated or unforeseen classes.

### Reference

Code repository : https://github.com/gsenthilvel/DesignStructural

