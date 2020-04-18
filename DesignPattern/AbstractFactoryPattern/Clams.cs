using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 蛤
    /// </summary>
    public interface IClams
    {
        public string ToString();
    }

    /// <summary>
    /// 新鲜的蛤
    /// </summary>
    public class FreshClams : IClams
    {
        public override String ToString()
        {
            return "长岛之声的新鲜蛤";
        }
    }

    /// <summary>
    /// 冷冻的蛤
    /// </summary>
    public class FrozenClams : IClams
    {
        public override String ToString()
        {
            return "切萨皮克湾的冷冻蛤";
        }
    }
}
