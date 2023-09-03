using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Implementations.Behaviors;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
