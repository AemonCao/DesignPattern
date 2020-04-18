using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 披萨原料工厂
    /// </summary>
    public interface PizzaIngredientFactory
    {
        public IDough createDough();
        public ISauce createSauce();
        public ICheese createCheese();
        public IVeggies[] createVeggies();
        public IPepperoni createPepperoni();
        public IClams createClam();
    }
    /// <summary>
    /// 纽约披萨原料工厂
    /// </summary>
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        };
            return veggies;
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams createClam()
        {
            return new FreshClams();
        }
    }

    /// <summary>
    /// 芝加哥披萨原料工厂
    /// </summary>
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = {
                new BlackOlives(),
                new Spinach(),
                new Eggplant()
            };
            return veggies;
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams createClam()
        {
            return new FrozenClams();
        }
    }
}
