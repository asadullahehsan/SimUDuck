using SimUDuck.Interfaces.Behaviors;

namespace SimUDuck.Interfaces.Ducks;

public abstract class Duck
{
    #region Varying Behavior

    protected IQuackBehavior quackBehavior;
    protected IFlyBehavior flyBehavior;

    public void SetFlyBehavior(IFlyBehavior fb) { flyBehavior = fb; }
    public void SetQuackBehavior(IQuackBehavior qb) { quackBehavior = qb; }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }
    #endregion

    #region Common Behavior
    public abstract void Display();
    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
    #endregion
}
