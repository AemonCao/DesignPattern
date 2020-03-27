using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.SimpleFactoryPattern.Pizzas;

namespace DesignPattern.SimpleFactoryPattern
{
    class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
