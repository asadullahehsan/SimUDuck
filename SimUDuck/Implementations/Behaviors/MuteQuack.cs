using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Implementations.Behaviors;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Silence");
    }
}
