using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SimpleFactoryPattern.Pizzas
{
    public class Pizza
    {
        /// <summary>
        /// 构造方法
        /// </summary>
       public Pizza() { }

        /// <summary>
        /// 准备 Pizza
        /// </summary>
        public void prepare()
        {
            Console.WriteLine("准备 Pizza!");
        }

        /// <summary>
        /// 烘培 Pizza
        /// </summary>
        public void bake()
        {
            Console.WriteLine("烘焙 Pizza!");
        }

        /// <summary>
        /// 切 Pizza
        /// </summary>
        public void cut()
        {
            Console.WriteLine("切 Pizza!");
        }

        /// <summary>
        /// 装箱 Pizza
        /// </summary>
        public void box()
        {
            Console.WriteLine("装箱 Pizza!");
        }
    }
}
