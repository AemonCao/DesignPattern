using System;
using System.Collections.Generic;
using DesignPattern.AbstractFactoryPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.orderPizza("cheese");
        }
    }
}
