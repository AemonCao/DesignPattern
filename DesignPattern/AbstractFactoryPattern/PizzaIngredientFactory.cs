using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    public interface PizzaIngredientFactory
    {
        public IDough createDough();
        public ISauce createSauce();
        public ICheese createCheese();
        public IVeggies[] createVeggies();
        public IPepperoni createPepperoni();
        public IClams createClam();
    }

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
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
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
}
