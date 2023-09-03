using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Implementations.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}
