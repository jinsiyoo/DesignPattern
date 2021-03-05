namespace Patterns.Creational.Builder
{
    public class Tester
    {
        public Tester()
        {
            Bartender b = new Bartender();
            b.GetOrder(new OldFashion());
            b.MakeOrder();
            b.GetOrder(new Martini());
            b.MakeOrder();
        }
    }
}