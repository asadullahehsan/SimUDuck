using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Implementations.Behaviors;

public class Squeak : IQuackBehavior
{
    public Squeak()
    {
        Console.WriteLine("Squeak ctor");

    }

    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
