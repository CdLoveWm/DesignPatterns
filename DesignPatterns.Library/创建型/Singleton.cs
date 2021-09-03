using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.创建型
{
    /// <summary>
    /// 单例模式 懒汉
    /// </summary>
    public class Singleton1
    {

        private static volatile Singleton1 instance = null;
        private static readonly object _lock = new object();
        private Singleton1() { }
        public Singleton1 GetInstance()
        {
            if (instance != null)
            {
                lock (_lock)
                {
                    if (instance != null)
                    {
                        instance = new Singleton1();
                    }
                }
            }
            return instance;
        }
    }
    /// <summary>
    /// 饿汉1
    /// </summary>
    public class Singleton2
    {
        private static readonly  Singleton2 instance = new Singleton2();
        private Singleton2() { }
        public Singleton2 GetInstance => instance;
    }

    /// <summary>
    /// 饿汉2
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 instance = null;
        private Singleton3() { }
        static Singleton3()
        {
            instance = new Singleton3();
        }
        public Singleton3 GetInstance => instance;
    }
}
