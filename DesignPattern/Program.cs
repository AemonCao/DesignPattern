using System;
using System.Collections.Generic;
using DesignPattern.FactoryMethodPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            nyPizzaStore.OrderPizza("cheese");
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            chicagoPizzaStore.OrderPizza("viggie");
        }
    }
}
