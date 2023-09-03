using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Implementations.Behaviors;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("Quack");
    }

}
