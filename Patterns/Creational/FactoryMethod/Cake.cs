using System;

namespace Patterns.Creational.FactoryMethod
{
    // 蛋糕的種類
    public enum CakeType
    {
        Chocolate,
        Strawberry,
    }

    // 創建蛋糕的介面
    public interface ICake
    {
        int Servings { get; set; }
        // 吃蛋糕
        void EatCake(); //同 public abstract 修飾;
    }

    // 實作巧克力蛋糕的類別
    public class ChocolateCake : ICake
    {
        public int Servings { get; set; }

        public ChocolateCake(int servings)
        {
            Servings = servings;
        }

        public void EatCake()
        {
            Servings--;
            Console.WriteLine($"Ate a ChocolateCake. { Servings } servings left. ");
        }
    }

    // 實作草莓蛋糕的類別
    public class StrawberryCake : ICake
    {
        public int Servings { get; set; }
        public StrawberryCake(int servings)
        {
            Servings = servings;
        }

        public void EatCake()
        {
            Servings--;
            Console.WriteLine($"Ate a StrawberryCake. { Servings } servings left. ");
        }
    }
}