using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 蔬菜
    /// </summary>
    public interface IVeggies
    {
        public string ToString();
    }

    /// <summary>
    /// 茄子
    /// </summary>
    public class Eggplant : IVeggies
    {
        public override string ToString()
        {
            return "茄子";
        }
    }

    /// <summary>
    /// 大蒜
    /// </summary>
    public class Garlic : IVeggies
    {
        public override string ToString()
        {
            return "大蒜";
        }
    }

    /// <summary>
    /// 菠菜
    /// </summary>
    public class Spinach : IVeggies
    {
        public override string ToString()
        {
            return "菠菜";
        }
    }

    /// <summary>
    /// 洋葱
    /// </summary>
    public class Onion : IVeggies
    {
        public override string ToString()
        {
            return "洋葱";
        }
    }

    /// <summary>
    /// 蘑菇
    /// </summary>
    public class Mushroom : IVeggies
    {
        public override string ToString()
        {
            return "蘑菇";
        }
    }

    /// <summary>
    /// 辣椒
    /// </summary>
    public class RedPepper : IVeggies
    {
        public override string ToString()
        {
            return "辣椒";
        }
    }

    /// <summary>
    /// 黑橄榄
    /// </summary>
    public class BlackOlives : IVeggies
    {
        public override string ToString()
        {
            return "黑橄榄";
        }
    }
}
