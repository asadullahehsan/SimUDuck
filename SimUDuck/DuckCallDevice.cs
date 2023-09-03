using SimUDuck.Implementations.Behaviors;
using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck;

public class DuckCallDevice
{
    IQuackBehavior quackBehavior;
    public DuckCallDevice()
    {
        quackBehavior = new Quack();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Display()
    {
        Console.WriteLine("I'm a duck call device");
    }

}
