using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 酱
    /// </summary>
    public interface ISauce
    {
        public string ToString();
    }

    /// <summary>
    /// 意大利西红柿酱
    /// </summary>
    public class MarinaraSauce : ISauce
    {
        public override string ToString()
        {
            return "意大利西红柿酱";
        }
    }

    /// <summary>
    /// 梅子番茄酱
    /// </summary>
    public class PlumTomatoSauce : ISauce
    {
        public override string ToString()
        {
            return "梅子西红柿酱";
        }
    }
}
