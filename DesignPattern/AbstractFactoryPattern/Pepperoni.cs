using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 意大利辣香肠
    /// </summary>
    public interface IPepperoni
    {
        public string toString();
    }

    public class SlicedPepperoni : IPepperoni
    {
        public String toString()
        {
            return "切意大利辣香肠";
        }
    }
}
