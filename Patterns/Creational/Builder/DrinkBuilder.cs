using System;

namespace Patterns.Creational.Builder
{
    interface IDrinkBuilder
    {
        //拿取容器
        void GetContainer();

        //混合素材
        void AddIngredients();

        //混合
        void Mix();

        //完成
        void Done();
    }

    public class OldFashion : IDrinkBuilder
    {
        public void GetContainer()
        {
            Console.WriteLine("Get a old fashion glass.");
        }

        public void AddIngredients()
        {
            Console.WriteLine("Add whiskey, Angostura bitters, sugar, ice and lemon-peel.");
        }

        public void Mix()
        {
            Console.WriteLine("Mix with small bar-spoon.");
        }

        public void Done()
        {
            Console.WriteLine("Leaving spoon in glass.");
        }
    }

    public class Martini : IDrinkBuilder
    {
        public void GetContainer()
        {
            Console.WriteLine("Get a cocktail glass.");
        }

        public void AddIngredients()
        {
            Console.WriteLine("Add Boker's bitters, Maraschino, Old Tom gin and ice.");
        }

        public void Mix()
        {
            Console.WriteLine("Shake up thoroughly.");
        }

        public void Done()
        {
            Console.WriteLine("Strain into a cocktail glass.");
        }
    }
}