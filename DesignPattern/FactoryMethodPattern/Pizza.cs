using System;
using System.Collections;

namespace DesignPattern.FactoryMethodPattern
{
    /// <summary>
    /// 披萨抽象类
    /// </summary>
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public ArrayList toppings = new ArrayList();

        /// <summary>
        /// 准备 Pizza
        /// </summary>
        public virtual void Prepare()
        {
            Console.WriteLine("Prepring " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
                Console.WriteLine("    " + toppings[i]);
        }

        /// <summary>
        /// 烘培 Pizza
        /// </summary>
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        /// <summary>
        /// 切 Pizza
        /// </summary>
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        /// <summary>
        /// 装箱 Pizza
        /// </summary>
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public String getName()
        {
            return name;
        }
    }

    /// <summary>
    /// 纽约芝士披萨
    /// </summary>
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }

    /// <summary>
    /// 纽约素食披萨
    /// </summary>
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Sauce and Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Veggie");
        }
    }

    /// <summary>
    /// 芝加哥芝士披萨
    /// </summary>
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    /// <summary>
    /// 芝加哥素食披萨
    /// </summary>
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Veggie");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

