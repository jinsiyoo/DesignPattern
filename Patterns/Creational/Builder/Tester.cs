namespace Patterns.Creational.Builder
{
    public class Tester
    {
        public Tester()
        {
            // 實作調酒師(主導者)
            DrinkDirector bartender = new DrinkDirector();
            
            // 跟調酒師點一杯古典雞尾酒
            bartender.GetOrder(new OldFashion());

            // 由調酒師製作
            bartender.MakeOrder();

            // 跟調酒師點一杯馬丁尼
            bartender.GetOrder(new Martini());

            // 由調酒師製作
            bartender.MakeOrder();
        }
    }
}