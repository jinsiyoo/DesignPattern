using System;
namespace Patterns.Creational.FactoryMethod
{
    // 蛋糕工廠
    public class CakeFactory
    {
        public ICake GetCake(CakeType type)
        {
            switch (type)
            {
                case CakeType.Chocolate:
                    Console.WriteLine("Factory made a Chocolate Cake(6 servings).");
                    return new ChocolateCake(6);
                case CakeType.Strawberry:
                    Console.WriteLine("Factory made a Strawberry Cake(8 servings).");
                    return new StrawberryCake(8);
                default:
                    throw new NotSupportedException();
            }

        }
    }
}