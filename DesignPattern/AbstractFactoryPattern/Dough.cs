using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// 面团
    /// </summary>
    public interface IDough
    {
        public string toString();
    }

    /// <summary>
    /// 厚皮面团
    /// </summary>
    public class ThickCrustDough : IDough
    {
        public string toString()
        {
            return "厚皮面团";
        }
    }

    /// <summary>
    /// 薄皮面团
    /// </summary>
    public class ThinCrustDough : IDough
    {
        public string toString()
        {
            return "薄皮面团";
        }
    }
}
