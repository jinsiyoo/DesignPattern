using System;

namespace Patterns.Creational.FactoryMethod
{
    public abstract class Cake
    {
        public abstract void MakeCake();
    }

    public class ChocolateCake : Cake
    {
        public override void MakeCake()
        {
            Console.WriteLine("Make a ChocolateCake.");
        }
    }

    public class StrawberryCake : Cake
    {
        public override void MakeCake()
        {
            Console.WriteLine("Make a ChocolateCake.");
        }
    }
}