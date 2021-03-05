namespace Patterns.Creational.FactoryMethod
{
    public class Tester
    {
        public Tester(){

            /* 簡單工廠模式 */

            // 實作蛋糕工廠物件
            CakeFactory factory = new CakeFactory();

            // 蛋糕介面 (不需要呼叫建構函式，也不需要指定明確的類別)
            IBirthdayCake cake;

            // 蛋糕工廠實作出一個巧克力蛋糕物件 (延遲至此，由工廠物件來實作巧克力蛋糕物件)
            cake = factory.GetCake(CakeType.Chocolate);

            // 蠟燭介面
            ICandle candle = (ICandle)cake;
            
            // 點蠟燭
            candle.LightCandle();
            
            // 吹蠟燭
            candle.BlowOutCandle();

            // 吃蛋糕 (使用蛋糕介面來吃一片蛋糕)
            cake.EatCake();
        }        
    }
}