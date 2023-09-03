﻿using SimUDuck.Implementations.Behaviors;
using SimUDuck.Interfaces.Ducks;

namespace SimUDuck.Implementations.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}
