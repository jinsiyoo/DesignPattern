namespace Patterns.Creational.FactoryMethod
{
    public class PatternPlayObject
    {
        public PatternPlayObject(){

            /* 簡單工廠模式 */

            // 實作蛋糕工廠物件
            CakeFactory factory = new CakeFactory();

            // 蛋糕介面 (不需要呼叫建構函式，也不需要指定明確的類別)
            ICake cake1, cake2;

            // 蛋糕工廠實作出一個巧克力蛋糕物件 (延遲至此，由工廠物件來實作巧克力蛋糕物件)
            cake1 = factory.GetCake(CakeType.Chocolate);
            // 吃蛋糕 (使用蛋糕介面來吃一片蛋糕)
            cake1.EatCake();

            // 蛋糕工廠實作出一個草莓蛋糕物件
            cake2 = factory.GetCake(CakeType.Strawberry);
            // 吃蛋糕
            cake2.EatCake();


        }        
    }
}