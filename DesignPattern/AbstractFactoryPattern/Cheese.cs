using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 起司
    /// </summary>
    public interface ICheese
    {
        public string ToString();
    }

    /// <summary>
    /// 芝士丝
    /// </summary>
    public class MozzarellaCheese : ICheese
    {
        public override string ToString()
        {
            return "芝士丝";
        }
    }

    /// <summary>
    /// 帕尔马干酪
    /// </summary>
    public class ParmesanCheese : ICheese
    {
        public override string ToString()
        {
            return "帕尔马干酪";
        }
    }

    /// <summary>
    /// 雷吉亚诺奶酪
    /// </summary>
    public class ReggianoCheese : ICheese
    {
        public override string ToString()
        {
            return "雷吉亚诺奶酪";
        }
    }
}
