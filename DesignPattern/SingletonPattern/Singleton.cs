namespace DesignPattern.SingletonPattern
{
    /// <summary>
    /// 单例
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 记录唯一实例的静态变量
        /// </summary>
        private static Singleton uniqueInstance;

        private static readonly object locker = new object();

        /// <summary>
        /// 私有的构造函数
        /// </summary>
        private Singleton() { }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns>唯一的 Singleton 实例</returns>
        public static Singleton getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singleton();
            return uniqueInstance;
        }
    }
}
