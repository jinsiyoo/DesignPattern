namespace Patterns.Creational.FactoryMethod
{
    public interface ICakeFactory
    {
         Cake CreateCake();
    }

    public class ChocolateCakeFactory : ICakeFactory
    {
        public Cake CreateCake()
        {
            return new ChocolateCake();
        }
    }

    public class StrawberryCakeFactory : ICakeFactory
    {
        public Cake CreateCake()
        {
            return new StrawberryCake();
        }
    }
}