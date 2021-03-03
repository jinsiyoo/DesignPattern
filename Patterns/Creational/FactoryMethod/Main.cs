namespace Patterns.Creational.FactoryMethod
{
    public class PatternPlayObject
    {
        public PatternPlayObject(){
            ICakeFactory factory;
            Cake cake;

            factory = new ChocolateCakeFactory();
            cake = factory.CreateCake();
            cake.MakeCake();

            factory = new StrawberryCakeFactory();
            cake = factory.CreateCake();
            cake.MakeCake();
        }        
    }
}