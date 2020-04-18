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
        public string ToString();
    }

    public class SlicedPepperoni : IPepperoni
    {
        public override String ToString()
        {
            return "切意大利辣香肠";
        }
    }
}
