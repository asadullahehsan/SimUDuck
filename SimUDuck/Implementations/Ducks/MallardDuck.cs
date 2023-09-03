using SimUDuck.Implementations.Behaviors;
using SimUDuck.Interfaces.Ducks;

namespace SimUDuck.Implementations.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
