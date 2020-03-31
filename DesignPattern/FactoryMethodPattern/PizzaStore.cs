namespace DesignPattern.FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }

    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NYStyleCheesePizza();
            else if (type.Equals("viggie"))
                return new NYStyleVeggiePizza();
            else
                return null;
        }
    }

    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new ChicagoStyleCheesePizza();
            else if (type.Equals("viggie"))
                return new ChicagoStyleVeggiePizza();
            else
                return null;
        }
    }
}
