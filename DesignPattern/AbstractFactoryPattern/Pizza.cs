using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    public abstract class Pizza
    {
        public String name;

        public IDough dough;
        public ISauce sauce;
        public IVeggies[] veggies;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClams clam;

        /// <summary>
        /// 准备
        /// </summary>
        public abstract void prepare();

        /// <summary>
        /// 烘焙
        /// </summary>
        public void bake()
        {
            Console.WriteLine("350摄氏度烘焙25分钟。");
        }

        /// <summary>
        /// 切
        /// </summary>
        public void cut()
        {
            Console.WriteLine("将披萨切成对角。");
        }

        /// <summary>
        /// 装盒
        /// </summary>
        public void box()
        {
            Console.WriteLine("将披萨放入盒中");
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("---- " + name + " ----\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append("\n");
            }
            if (sauce != null)
            {
                result.Append(sauce);
                result.Append("\n");
            }
            if (cheese != null)
            {
                result.Append(cheese);
                result.Append("\n");
            }
            if (veggies != null)
            {
                for (int i = 0; i < veggies.Length; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (clam != null)
            {
                result.Append(clam);
                result.Append("\n");
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append("\n");
            }
            return result.ToString();
        }
    }

    /// <summary>
    /// 芝士披萨
    /// </summary>
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("准备：" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }

    /// <summary>
    /// 蛤蜊披萨
    /// </summary>
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("准备：" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();
        }
    }

    /// <summary>
    /// 素食披萨
    /// </summary>
    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("准备：" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            veggies = ingredientFactory.createVeggies();
        }
    }

    /// <summary>
    /// 意大利辣香肠比萨
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("准备：" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            veggies = ingredientFactory.createVeggies();
            pepperoni = ingredientFactory.createPepperoni();
        }
    }
}