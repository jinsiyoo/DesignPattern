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
    public interface IBirthdayCake
    {
        int Servings { get; set; }
        // 吃蛋糕
        void EatCake(); //同 public abstract 修飾;
    }

    public interface ICandle
    {
        void LightCandle();

        void BlowOutCandle();
    }

    // 實作巧克力蛋糕的類別
    public class ChocolateCake : IBirthdayCake, ICandle
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

        public void LightCandle()
        {
            Console.WriteLine($"ChocolateCake's candle has lighted. ");
        }

        public void BlowOutCandle()
        {
            Console.WriteLine($"ChocolateCake's candle has blown. ");
        }
    }

    // 實作草莓蛋糕的類別
    public class StrawberryCake : IBirthdayCake
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

        public static void LightCandle()
        {
            Console.WriteLine($"StrawberryCake's candle has lighted. ");
        }

        public static void BlowOutCandle()
        {
            Console.WriteLine($"StrawberryCake's candle has blown. ");
        }
    }
}