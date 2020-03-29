using System;

namespace DesignPattern.SimpleFactoryPattern
{
    /// <summary>
    /// 披萨抽象类
    /// </summary>
    public abstract class Pizza
    {
        /// <summary>
        /// 准备 Pizza
        /// </summary>
        public abstract void Prepare();

        /// <summary>
        /// 烘培 Pizza
        /// </summary>
        public abstract void Bake();

        /// <summary>
        /// 切 Pizza
        /// </summary>
        public abstract void Cut();

        /// <summary>
        /// 装箱 Pizza
        /// </summary>
        public abstract void Box();
    }

    /// <summary>
    /// 芝士披萨
    /// </summary>
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Console.WriteLine("芝士披萨");
        }

        public override void Prepare()
        {
            Console.WriteLine("准备芝士 Pizza!");
        }

        public override void Bake()
        {
            Console.WriteLine("烘焙芝士 Pizza!");
        }

        public override void Cut()
        {
            Console.WriteLine("切芝士 Pizza!");
        }

        public override void Box()
        {
            Console.WriteLine("装箱芝士 Pizza!");
        }
    }

    /// <summary>
    /// 蛤披萨
    /// </summary>
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Console.WriteLine("蛤披萨");
        }

        public override void Prepare()
        {
            Console.WriteLine("准备蛤 Pizza!");
        }

        public override void Bake()
        {
            Console.WriteLine("烘焙蛤 Pizza!");
        }

        public override void Cut()
        {
            Console.WriteLine("切蛤 Pizza!");
        }

        public override void Box()
        {
            Console.WriteLine("装箱蛤 Pizza!");
        }
    }

    /// <summary>
    /// 意大利辣香肠披萨
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Console.WriteLine("意大利辣香肠披萨");
        }
        public override void Prepare()
        {
            Console.WriteLine("准备意大利辣香肠 Pizza!");
        }

        public override void Bake()
        {
            Console.WriteLine("烘焙意大利辣香肠 Pizza!");
        }

        public override void Cut()
        {
            Console.WriteLine("切意大利辣香肠 Pizza!");
        }

        public override void Box()
        {
            Console.WriteLine("装箱意大利辣香肠 Pizza!");
        }
    }

    /// <summary>
    /// 素食披萨
    /// </summary>
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Console.WriteLine("素食披萨");
        }

        public override void Prepare()
        {
            Console.WriteLine("准备素食披萨 Pizza!");
        }

        public override void Bake()
        {
            Console.WriteLine("烘焙素食披萨 Pizza!");
        }

        public override void Cut()
        {
            Console.WriteLine("切素食披萨 Pizza!");
        }

        public override void Box()
        {
            Console.WriteLine("装箱素食披萨 Pizza!");
        }
    }
}
