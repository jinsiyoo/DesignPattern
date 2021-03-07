namespace Patterns.Creational.Builder
{

    class DrinkDirector
    {
        private IDrinkBuilder builder;

        public void GetOrder(IDrinkBuilder builder)
        {
            this.builder = builder;
        }

        public void MakeOrder()
        {
            this.builder.GetContainer();
            this.builder.AddIngredients();
            this.builder.Mix();
            this.builder.Done();
        }
    }
}